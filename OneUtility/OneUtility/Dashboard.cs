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
    public partial class Dashboard : Form
    {
        // Refrences
        Random rand;

        public Dashboard()
        {
            InitializeComponent();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Populate ComboBox
            comboBox_month.Items.Add("January");
            comboBox_month.Items.Add("February");
            comboBox_month.Items.Add("March");
            comboBox_month.Items.Add("April");
            comboBox_month.Items.Add("May");
            comboBox_month.Items.Add("June");
            comboBox_month.Items.Add("July");
            comboBox_month.Items.Add("August");
            comboBox_month.Items.Add("Semptember");
            comboBox_month.Items.Add("October");
            comboBox_month.Items.Add("November");
            comboBox_month.Items.Add("December");

            // Disbale Buttons
            textBox_amount.Enabled = false;
            textBox_status.Enabled = false;
            textBox_unit.Enabled = false;
            //--sbutton_payBill.Enabled = false;

            //Label
            string username = (DbConnect.activeUser!=null)?DbConnect.activeUser.ToString():" ";
            label_displayUser.Text = username;

            // Intialize User Details
            textBox_customerName.Text = DbConnect.GetData("SELECT * FROM gx_utility.tbl_users WHERE user_id='"+username+"';", "name");
            textBox_customerId.Text = DbConnect.GetData("SELECT * FROM gx_utility.tbl_users WHERE user_id='" + username + "';", "user_id");
            textBox_location.Text = DbConnect.GetData("SELECT * FROM gx_utility.tbl_users WHERE user_id='" + username + "';", "location");
            textBox_mobile.Text = DbConnect.GetData("SELECT * FROM gx_utility.tbl_users WHERE user_id='" + username + "';", "mobile");
            textBox_last_pay.Text = DbConnect.GetData("SELECT * FROM gx_utility.tbl_users WHERE user_id='" + username + "';", "last_pay");
            textBox_email.Text = DbConnect.GetData("SELECT * FROM gx_utility.tbl_users WHERE user_id='" + username + "';", "email");
            label_uid.Text = DbConnect.GetData("SELECT * FROM gx_utility.tbl_users WHERE user_id='" + username + "';", "id");
            
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Pay Your Bill
            string query;
            
            query = String.Format("UPDATE gx_utility.tbl_bill SET month='{0}' WHERE id='{1}'", comboBox_month.SelectedIndex.ToString(),label_uid.Text.ToString());
            query = String.Format("UPDATE gx_utility.tbl_bill SET amount='{0}' WHERE id='{1}'", textBox_amount.Text.ToString(), label_uid.Text.ToString());
            query = String.Format("UPDATE gx_utility.tbl_bill SET unit='{0}' WHERE id='{1}'", textBox_unit.Text.ToString(), label_uid.Text.ToString());
            query = String.Format("UPDATE gx_utility.tbl_bill SET isPaid='{0}' WHERE id='{1}'", "1", label_uid.Text.ToString());
            var msg= DbConnect.InsertData(query);
            MessageBox.Show(null, msg, "Status", MessageBoxButtons.OK,MessageBoxIcon.Information);
            
            
            //Move to gateway
            new CardSystem().Show();
            this.Hide();


            // Reset The Fields
            textBox_amount.Clear();
            textBox_unit.Clear();
            textBox_status.Clear();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button_Check_Click(object sender, EventArgs e)
        {
            // Enable
            textBox_status.Enabled = true;
            textBox_amount.Enabled = true;
            textBox_unit.Enabled = true;

            



            // Check Status Button
            textBox_amount.Text = DbConnect.GetData("SELECT * FROM gx_utility.tbl_bill WHERE month='"+comboBox_month.SelectedIndex+"';","amount");
            
            // Units
            textBox_unit.Text = DbConnect.GetData("SELECT * FROM gx_utility.tbl_bill WHERE month='" + comboBox_month.SelectedIndex + "';", "unit");

            if(DbConnect.GetData("SELECT * FROM gx_utility.tbl_bill WHERE month='" + comboBox_month.SelectedIndex + "';", "isPaid")=="0")
            {
                textBox_status.Text = "Not PAID";
                
                // Then, Enable Pay Button
                button_payBill.Enabled = true;
            }
            else if (DbConnect.GetData("SELECT * FROM gx_utility.tbl_bill WHERE month='" + comboBox_month.SelectedIndex + "';", "isPaid") == "1")
            {
                textBox_status.Text = "PAID";
            }

            if(textBox_amount.Text==String.Empty || textBox_unit.Text == String.Empty)
            {
                // Text Generation
                rand = new Random();

                textBox_amount.Text = rand.Next(400, 1000).ToString();
                textBox_unit.Text = rand.Next(50, 400).ToString();
            }

            // Paid
            if(textBox_status.Text == String.Empty)
            {
                textBox_status.Text = "Not PAID";
            }
        
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            // LogoutButton
            new Form1().Show();
            this.Hide();
            
        }
    }
}
