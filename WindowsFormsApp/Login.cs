﻿using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Login : Form
    {
        public string Username { get; private set; } // Lưu trữ thông tin đăng nhập
        public Login()
        {
            InitializeComponent();
        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            string username = DN_username.Text;
            string password = DN_password.Text;

            if (AuthenticateUser(username, password))
            {
                // Đăng nhập thành công
                Username = username; // Lưu thông tin đăng nhập vào biến

                MessageBox.Show("Đăng nhập thành công!");

                General general_user = new General();
                general_user.Show();
                this.Hide();
            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }
        private bool AuthenticateUser(string username, string password)
        {
            string connectionString = string.Format(@"Data Source=(DESCRIPTION =
                (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))
                (CONNECT_DATA =
                    (SERVER = DEDICATED)
                    (SERVICE_NAME = XE)
                )
            );User Id={0};Password={1};DBA Privilege=SYSDBA;", username, password);

            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true; // Kết nối thành công
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối tới cơ sở dữ liệu: " + ex.Message);
                    return false; // Kết nối thất bại
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

/*        private void button_dangnhap_Click(object sender, EventArgs e)
        {

        }*/

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
