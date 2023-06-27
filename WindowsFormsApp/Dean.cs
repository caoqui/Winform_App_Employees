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
    public partial class Dean : Form
    {
        private OracleDataAdapter dataAdapter;
        private DataTable dataTable;
        public Dean()
        {
            InitializeComponent();

            dt_ngaybd_da.CustomFormat = " "; // Đặt format thành một khoảng trắng để hiển thị giá trị null
            dt_ngaybd_da.Format = DateTimePickerFormat.Custom;

            dt_ngaybd_da.ValueChanged += dt_ngaybd_da_ValueChanged;
        }

        private void Dean_Load(object sender, EventArgs e)
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
                data_dean.DataSource = dataTable;

            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            General home = new General();
            home.Show();
            this.Hide();
        }

        private void dt_ngaybd_da_ValueChanged(object sender, EventArgs e)
        {
            if (dt_ngaybd_da.Value == dt_ngaybd_da.MinDate)
            {
                dt_ngaybd_da.CustomFormat = " "; // Hiển thị giá trị null nếu giá trị DateTimePicker bằng giá trị MinDate
            }
            else
            {
                dt_ngaybd_da.CustomFormat = "dd/MM/yyyy"; // Đặt format ngày tháng mong muốn
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mada = tb_mada_da.Text;
            string tenda = tb_tenda_da.Text;
            DateTime ngaybd;

            if (dt_ngaybd_da.Value != null)
            {
                ngaybd = dt_ngaybd_da.Value;
                // Sử dụng giá trị selectedValue trong các xử lý dữ liệu khác
            }

            string phong = tb_phong_da.Text;
        }
    }
}
