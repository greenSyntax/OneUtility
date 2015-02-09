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
    public partial class DataSheet : Form
    {
        public DataSheet()
        {
            InitializeComponent();
        }

        private void DataSheet_Load(object sender, EventArgs e)
        {
            // Load Grid
            gridView_userDetails.DataSource= DbConnect.GetGridData("SELECT * FROM gx_utility.tbl_users");

        }
    }
}
