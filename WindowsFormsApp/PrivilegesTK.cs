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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;


namespace WindowsFormsApp
{
    public partial class PrivilegesTK : Form
    {
        public PrivilegesTK()
        {
            InitializeComponent();

            cbb_bang_pri.Items.Add("NHANVIEN");
            cbb_bang_pri.Items.Add("PHONGBAN");
            cbb_bang_pri.Items.Add("DEAN");
            cbb_bang_pri.Items.Add("PHANCONG");

            cbb_bang_pri.SelectedIndexChanged += cbb_bang_pri_SelectedIndexChanged;

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

        private void cbb_bang_pri_SelectedIndexChanged(object sender, EventArgs e)
        {

            string bang = cbb_bang_pri.SelectedItem.ToString();
            privileges_data.DataSource = OracleHelper.GET_OBJECT_PRIVILEGES(bang);
        }
    }
}
