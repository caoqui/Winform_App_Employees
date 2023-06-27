using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Phongban : Form
    {
        private OracleDataAdapter dataAdapter;
        private DataTable dataTable;
        public Phongban()
        {
            InitializeComponent();
        }

        private void Phongban_Load(object sender, EventArgs e)
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
                data_phongban.DataSource = dataTable;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            General home = new General();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_update_pb_Click(object sender, EventArgs e)
        {
            string mapb = tb_mapb_pb.Text;
            string tenpb = tb_tenpb_pb.Text;
            string trphg = tb_trphg_pb.Text;
        }
    }
}
