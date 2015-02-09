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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Check
            if(textBox_userName.Text!=null && textBox_UniqueId.Text!=null && textBox_password.Text !=null && textBox_mobileNo.Text != null && textBox1_customerName.Text!=null && textBox_emailAddress.Text != null)
            {
                string msg;

                // Valid: Go for INSERT 
                string query = String.Format("INSERT INTO gx_utility.tbl_users(id, user_id, password, name, location, mobile, last_pay, email) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')",textBox_UniqueId.Text.ToString(), textBox_userName.Text.ToString(), textBox_password.Text.ToString(), textBox1_customerName.Text.ToString(), comboBox_location.SelectedItem.ToString(), textBox_mobileNo.Text.ToString(), "NO", textBox_emailAddress.Text.ToString());
                MessageBox.Show(query);
                msg= DbConnect.InsertData(query);
                
                // For tbl_bill
                msg= DbConnect.InsertData("INSERT INTO gx_utility.tbl_bill(id,month, amount, isPaid, unit) VALUES('"+textBox_UniqueId.Text.ToString()+"','0','0','0','0');");

                MessageBox.Show(null,msg,"Status",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                label_register.Text = "Error: You have missed some fields !!";
            }
        }

        private void button_Generate_Click(object sender, EventArgs e)
        {
            // Generate Unique ID
            Guid uid = Guid.NewGuid();
            textBox_UniqueId.Text = uid.ToString();
            textBox_UniqueId.Enabled = false;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Verifiy Username
            if(DbConnect.GetData("SELECT * FROM gx_utility.tbl_users WHERE user_id='"+textBox_userName.Text.ToString()+"';","user_id")==null)
            {
                Label_userError.Text = "Valid User-Name";
                button_Register.Enabled = true;
            }
            else
            {
                // If Users already exist.
                Label_userError.Text = "User-Name is already in Use!!";
            }
        }

        private void Registration_Load(object sender, EventArgs e)
        {
            // Intialize
            button_Register.Enabled = false;


        }
    }
}
