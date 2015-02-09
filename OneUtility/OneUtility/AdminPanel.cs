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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void buton_AddUsers_Click(object sender, EventArgs e)
        {
            //Add USers
            new Registration().Show();
        }

        private void button_DataSheet_Click(object sender, EventArgs e)
        {
            // Show DataSheet Form
            new DataSheet().Show();
        }

        private void button_shell_Click(object sender, EventArgs e)
        {
            // Show Shell Form
            new Shell().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Logout
            new Form1().Show();
            this.Hide();
        }
    }
}
