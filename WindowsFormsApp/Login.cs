using Oracle.ManagedDataAccess.Client;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public static class DatabaseManager
    {
        public static OracleConnection Connection { get; set; }
    }

    public partial class Login : Form
    {
        public string Username { get; private set; } // Lưu trữ thông tin đăng nhập

        public Login()
        {
            InitializeComponent();
            DN_password.PasswordChar = '*';
            DN_password.UseSystemPasswordChar = true;

        }

        private void button_dangnhap_Click(object sender, EventArgs e)
        {
            string username = DN_username.Text;
            string password = DN_password.Text;

            if (AuthenticateUser(username, password))
            {
                // Đăng nhập thành công
                Username = username; // Lưu thông tin đăng nhập vào biến
                if( Username == "ATBM")
                {
                    Users admin = new Users();
                    admin.Show();
                    this.Hide();
                }
                else
                {
                    General general_user = new General();
                    general_user.Show();
                    this.Hide();
                }

                MessageBox.Show("Đăng nhập thành công!");


            }
            else
            {
                // Đăng nhập thất bại
                MessageBox.Show("Đăng nhập thất bại!");
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            string connectionString;
            if (username != "sys")
            {
                connectionString = string.Format(@"Data Source=(DESCRIPTION =
                (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))
                (CONNECT_DATA =
                    (SERVER = DEDICATED)
                    (SERVICE_NAME = XE)
                )
            );User Id={0};Password={1};", username, password);
            } else
            {
                connectionString = string.Format(@"Data Source=(DESCRIPTION =
                (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))
                (CONNECT_DATA =
                    (SERVER = DEDICATED)
                    (SERVICE_NAME = XE)
                )
            );User Id={0};Password={1}; DBA Privilege=SYSDBA;", username, password);
            }
            


            try
            {
                DatabaseManager.Connection = new OracleConnection(connectionString);
                DatabaseManager.Connection.Open();
                return true; // Kết nối thành công
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối tới cơ sở dữ liệu: " + ex.Message);
                return false; // Kết nối thất bại
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
