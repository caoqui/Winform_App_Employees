using Oracle.ManagedDataAccess.Client;
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
    public partial class Phancong : Form
    {
        private OracleDataAdapter dataAdapter;
        private DataTable dataTable;
        public Phancong()
        {
            InitializeComponent();
        }

        private void Phancong_Load(object sender, EventArgs e)
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
                data_phancong.DataSource = dataTable;

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            General home = new General();
            home.Show();
            this.Hide();
        }
    }
}
