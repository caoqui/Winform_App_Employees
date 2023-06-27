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

            dt_thoigian_pc.CustomFormat = " "; // Đặt format thành một khoảng trắng để hiển thị giá trị null
            dt_thoigian_pc.Format = DateTimePickerFormat.Custom;

            dt_thoigian_pc.ValueChanged += dt_thoigian_pc_ValueChanged;
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

        private void dt_thoigian_pc_ValueChanged(object sender, EventArgs e)
        {
            if (dt_thoigian_pc.Value == dt_thoigian_pc.MinDate)
            {
                dt_thoigian_pc.CustomFormat = " "; // Hiển thị giá trị null nếu giá trị DateTimePicker bằng giá trị MinDate
            }
            else
            {
                dt_thoigian_pc.CustomFormat = "dd/MM/yyyy"; // Đặt format ngày tháng mong muốn
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string manv = tb_manv_pc.Text;
            string mada = tb_mada_pc.Text;
            DateTime thoigian;

            if (dt_thoigian_pc.Value != null)
            {
                thoigian = dt_thoigian_pc.Value;
                // Sử dụng giá trị selectedValue trong các xử lý dữ liệu khác
            }
        }
    }
}
