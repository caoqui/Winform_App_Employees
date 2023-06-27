using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Nhanvien : Form
    {
        private OracleDataAdapter dataAdapter;
        private DataTable dataTable;

        public Nhanvien()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            General home = new General();
            home.Show();
            this.Hide();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            // Kiểm tra kết nối
            if (DatabaseManager.Connection != null)
            {
                // Tạo câu truy vấn
                string query = "SELECT * FROM ATBM.NV_NV_VIEW";

                // Khởi tạo DataAdapter và DataTable
                dataAdapter = new OracleDataAdapter(query, DatabaseManager.Connection);
                dataTable = new DataTable();

                // Đổ dữ liệu từ Oracle vào DataTable
                dataAdapter.Fill(dataTable);

                // Đặt DataTable là nguồn dữ liệu cho DataGridView
                data_nhanvien.DataSource = dataTable;

                MessageBox.Show("Load dữ liệu!");
            }
        }

        private void data_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
