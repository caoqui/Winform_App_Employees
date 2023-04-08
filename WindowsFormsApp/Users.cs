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
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            //string tableName = "TAIKHOAN";
            //dataAccount.DataSource = OracleHelper.GetRoles(tableName);
            //dataAccount.DataSource = OracleHelper.GetAccounts();

            dataAccount.DataSource = OracleHelper.GetRoles();
        }
    }
}
