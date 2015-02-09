using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;


namespace OneUtility
{
    class DbConnect
    {
        /* Workbench : mySQL Workbecnh 6.1
         * Database Name: gx_utility 
         * 
         * Table Name: tbl_users , tbl_bill 
         * 
         * Host: localhost
         * Port: 3306
         * UserName : root
         * Password : 
         * PC : gr33n | Abhix
         */

        public static string activeUser { get; set; }
        public static Int32 uid { get; set; }

        // Connection STRING
        static string myConnectionString = "datasource=127.0.0.1; port=3306; username=root; password=root";

        public static string Connect(string query)
        {
            MySqlConnection myConn=null; 

            try
            {
                
                myConn = new MySqlConnection(myConnectionString);

                
                MySqlCommand command=new MySqlCommand(query, myConn);

                MySqlDataReader reader;
                myConn.Open();

                reader = command.ExecuteReader();
                int count = 0;

                while(reader.Read())
                {
                    count++;
                }
                if(count==1)
                {
                    return "Success";
                }
                else if(count>1)
                {
                    return "More than One Users";
                }
                else
                {
                    return "error";
                }
                
            }
            catch(Exception ex)
            {
                return ex.Message.ToString();
            }
            finally
            {
                myConn.Close();
            }
        }

        public static string InsertData(string query)
        {
            MySqlConnection myConnection=new MySqlConnection(myConnectionString);
            MySqlCommand cmd=new MySqlCommand(query, myConnection);

            MySqlDataReader reader;
            try
            {
                myConnection.Open();
                reader= cmd.ExecuteReader();

                return "Successfully Executed.";
            }
            catch(Exception ex)
            {
                return "Error:" + ex.Message.ToString();
            }
        }

        public static BindingSource GetGridData(string query)
        {
            // For My DataGrid View
            MySqlConnection conDatabase = new MySqlConnection(myConnectionString);
            MySqlCommand CMD = new MySqlCommand(query, conDatabase
                );

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = CMD;

            DataTable dataset = new DataTable();
            adapter.Fill(dataset);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = dataset;
            adapter.Update(dataset);

            return bSource; 
        }

        public static string GetData(string query, string collumn)
        {
            MySqlConnection myConn = null;

            try
            {
               // string myConnectionString = "datasource=127.0.0.1; port=3306; username=root; password=root";
                myConn = new MySqlConnection(myConnectionString);


                MySqlCommand command = new MySqlCommand(query, myConn);

                MySqlDataReader reader;
                myConn.Open();

                reader = command.ExecuteReader();
                string val=null;

                while (reader.Read())
                {
                    val = reader.GetString(collumn);
                    
                }

                return val;
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
            finally
            {
                myConn.Close();
            }
        }
    }
}
