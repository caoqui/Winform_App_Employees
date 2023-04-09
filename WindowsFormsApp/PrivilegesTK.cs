using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyApp;


namespace WindowsFormsApp
{
    public partial class PrivilegesTK : Form
    {
        public PrivilegesTK()
        {
            InitializeComponent();
            privileges_data.DataSource = OracleHelper.GET_OBJECT_PRIVILEGES("TAIKHOAN");
        }

        private void privileges_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_home_privileges_tk_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();
        }
    }
}
