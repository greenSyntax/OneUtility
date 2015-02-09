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
    public partial class CardSystem : Form
    {
        public CardSystem()
        {
            InitializeComponent();
        }

        string selectedVar;

        private void button1_Click(object sender, EventArgs e)
        {
           if(DialogResult.OK==MessageBox.Show(null,"Thank You For Paying from  "+selectedVar.ToString(), "Status",MessageBoxButtons.OK,MessageBoxIcon.Information))
           {
               new Form1().Show();
               this.Hide();
           }
            
        }

        private void radioButton_debit_CheckedChanged(object sender, EventArgs e)
        {
            selectedVar = "Debit Card";
        }

        private void radioButton_creidt_CheckedChanged(object sender, EventArgs e)
        {
            selectedVar = "Credit Card";
        }

        private void radioButton_internet_CheckedChanged(object sender, EventArgs e)
        {
            selectedVar = "Internet Banking";
        }
    }
}
