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

            dataAccount.DataSource = OracleHelper.GetAccounts();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            //string tableName = "TAIKHOAN";
            //dataAccount.DataSource = OracleHelper.GetRoles(tableName);
            

            //dataAccount.DataSource = OracleHelper.Manager_User_Role("HIEU", "ALTER", "1234");
            //OracleHelper.Grant("QUI", "DELETE");
            //dataAccount.DataSource = OracleHelper.GET_OBJECT_PRIVILEGES("QUI");

        }

        private void btn_view_user_Click(object sender, EventArgs e)
        {
            dataAccount.DataSource = OracleHelper.GetAccounts();
        }

        private void btn_view_roles_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Grant_user grant_user = new Grant_user();
            grant_user.Show();
            this.Hide();
        }

        private void btn_view_privileges_Click(object sender, EventArgs e)
        {
            PrivilegesTK privileges_tk = new PrivilegesTK();
            privileges_tk.Show();
            this.Hide();

        }

        private void btn_change_pw_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;
            string newpass = textBox_password.Text;

            string p_action = "ALTER";

            OracleHelper.Manager_User_Role(username, p_action, newpass);
        }

        private void btn_delete_user_Click(object sender, EventArgs e)
        {
            string username = textBox_username.Text;

            OracleHelper.DELETE_USER(username);
        }
    }
}
