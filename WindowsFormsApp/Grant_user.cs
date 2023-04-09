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
    public partial class Grant_user : Form
    {
        public Grant_user()
        {
            InitializeComponent();

            comboBox1.Items.Add("INSERT");
            comboBox1.Items.Add("SELECT");
            comboBox1.Items.Add("UPDATE");
            comboBox1.Items.Add("DELETE");

            comboBox2.Items.Add("GRANTEE");
            comboBox2.Items.Add("TABLE_NAME");
            comboBox2.Items.Add("PRIVILEGE");
            comboBox2.Items.Add("GRANTABLE");
        }

        private void Grant_user_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_home_grant_user_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_username_grant.Text;
            string quyen = comboBox1.SelectedItem.ToString();
            string bang = textBox_bang_grant.Text;
            string thuoctinh = comboBox2.SelectedItem.ToString();

            string allowgrant;

            if (checkBox_grant.Checked)
            {
                // Checkbox đã được chọn
                allowgrant = " WITH GRANT OPTION";
            }
            else
            {
                // Checkbox không được chọn
                allowgrant = "";
            }


            OracleHelper.Grant(username, quyen, bang, thuoctinh, allowgrant);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_revoke_grant_Click(object sender, EventArgs e)
        {
            string username = textBox_username_grant.Text;
            string quyen = comboBox1.SelectedItem.ToString();
            string bang = textBox_bang_grant.Text;
            string thuoctinh = comboBox2.SelectedItem.ToString();

            OracleHelper.Revoke(username, quyen, bang, thuoctinh);
        }
    }
}
