using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneUtility
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Login Button
            var msg= DbConnect.Connect("SELECT * FROM gx_utility.tbl_users WHERE user_id='"+textBox_UserID.Text+"' AND password='"+textBox_Password.Text+"'");
            if (msg.ToString() == "Success")
            {
                //Special Case
                if (textBox_UserID.Text == "admin")
                {
                    this.Hide(); // Hide Form
                    new AdminPanel().Show();
                }
                else
                {
                    //Pass to Connect
                    DbConnect.activeUser = textBox_UserID.Text.ToString();

                    this.Hide(); // Hide Form
                    new Dashboard().Show(); // Navigate to New Page
                    
                }
                
            }
            else
            {
                // Reset Fields
                textBox_UserID.Clear();
                textBox_Password.Clear();

                // Error Message
                Label_error.ForeColor = Color.Red;
                Label_error.Text = "Sorry !! You have Error in Authentication";
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
