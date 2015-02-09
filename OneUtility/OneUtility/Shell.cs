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
    public partial class Shell : Form
    {
        public Shell()
        {
            InitializeComponent();
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            var msg = DbConnect.InsertData(textBox_query.Text.ToString());
            MessageBox.Show(null, msg.ToString(), "SQL Query Status", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
