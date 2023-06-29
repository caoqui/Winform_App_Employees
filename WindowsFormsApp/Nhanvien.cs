using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp
{
    public partial class Nhanvien : Form
    {
        private OracleDataAdapter dataAdapter;
        private DataTable dataTable;

        public Nhanvien()
        {
            InitializeComponent();

            dt_ngaysinh_nv.CustomFormat = " "; // Đặt format thành một khoảng trắng để hiển thị giá trị null
            dt_ngaysinh_nv.Format = DateTimePickerFormat.Custom;

            dt_ngaysinh_nv.ValueChanged += dt_ngaysinh_nv_ValueChanged;

            dd_phai_nv.Items.Add("Male");
            dd_phai_nv.Items.Add("Female");

            cbb_vaitro_nv.Items.Add("QL trực tiếp");
            cbb_vaitro_nv.Items.Add("Trưởng phòng");
            cbb_vaitro_nv.Items.Add("Tài chính");
            cbb_vaitro_nv.Items.Add("Nhân sự");
            cbb_vaitro_nv.Items.Add("Trưởng đề án");
            cbb_vaitro_nv.Items.Add("Nhân viên");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            General home = new General();
            home.Show();
            this.Hide();
        }

        private void Nhanvien_Load(object sender, EventArgs e)
        {
            /*// Kiểm tra kết nối
            if (DatabaseManager.Connection != null)
            {
                // Tạo câu truy vấn

                string query = "SELECT * FROM ATBM.NV_NV_VIEW";
               *//* string query = "select get_records from dual";*//*


                // Khởi tạo DataAdapter và DataTable
                dataAdapter = new OracleDataAdapter(query, DatabaseManager.Connection);

                dataTable = new DataTable();


                // Đổ dữ liệu từ Oracle vào DataTable
                dataAdapter.Fill(dataTable);

                // Đặt DataTable là nguồn dữ liệu cho DataGridView
                data_nhanvien.DataSource = dataTable;

            }*/
            if (DatabaseManager.Connection != null)
            {
                try
                {
                    // Tạo câu truy vấn SQL
                    string query = "SELECT ATBM.get_vaitro FROM dual";

                    // Khởi tạo OracleCommand để thực thi câu truy vấn
                    OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);

                    // Khởi tạo OracleDataAdapter để lấy dữ liệu từ câu truy vấn
                    OracleDataAdapter dataAdapter = new OracleDataAdapter(command);

                    // Khởi tạo DataTable để lưu trữ kết quả truy vấn
                    DataTable dataTable = new DataTable();

                    // Đổ dữ liệu từ DataAdapter vào DataTable
                    dataAdapter.Fill(dataTable);

                    // Kiểm tra và hiển thị kết quả
                    string result;
                    string query_all;
                    if (dataTable.Rows.Count > 0)
                    {
                        result = dataTable.Rows[0][0].ToString();
                        MessageBox.Show(result);
                        if (result == "Nhân viên" || result == "Trưởng đề án")
                        {
                            query_all = "SELECT * FROM ATBM.NV_NV_VIEW";

                            if (DatabaseManager.Connection != null)
                            {
                                // Tạo câu truy vấn


                                // Khởi tạo DataAdapter và DataTable
                                dataAdapter = new OracleDataAdapter(query_all, DatabaseManager.Connection);
                                dataTable = new DataTable();

                                // Đổ dữ liệu từ Oracle vào DataTable
                                dataAdapter.Fill(dataTable);

                                // Đặt DataTable là nguồn dữ liệu cho DataGridView
                                data_nhanvien.DataSource = dataTable;

                            }
                        }
                        else if (result == "Trưởng phòng")
                        {
                            query_all = "SELECT * FROM ATBM.TP_NV_VIEW";
                            if (DatabaseManager.Connection != null)
                            {
                                // Tạo câu truy vấn


                                // Khởi tạo DataAdapter và DataTable
                                dataAdapter = new OracleDataAdapter(query_all, DatabaseManager.Connection);
                                dataTable = new DataTable();

                                // Đổ dữ liệu từ Oracle vào DataTable
                                dataAdapter.Fill(dataTable);

                                // Đặt DataTable là nguồn dữ liệu cho DataGridView
                                data_nhanvien.DataSource = dataTable;

                            }
                        }
                        else if (result == "Nhân sự" || result == "Tài chính")
                        {
                            query_all = "SELECT * FROM ATBM.NHANVIEN";
                            if (DatabaseManager.Connection != null)
                            {
                                // Tạo câu truy vấn


                                // Khởi tạo DataAdapter và DataTable
                                dataAdapter = new OracleDataAdapter(query_all, DatabaseManager.Connection);
                                dataTable = new DataTable();

                                // Đổ dữ liệu từ Oracle vào DataTable
                                dataAdapter.Fill(dataTable);

                                // Đặt DataTable là nguồn dữ liệu cho DataGridView
                                data_nhanvien.DataSource = dataTable;

                            }
                        }
                        else if (result == "QL Trực tiếp")
                        {
                            query_all = "SELECT * FROM ATBM.QL_NV_VIEW";
                            if (DatabaseManager.Connection != null)
                            {
                                // Tạo câu truy vấn


                                // Khởi tạo DataAdapter và DataTable
                                dataAdapter = new OracleDataAdapter(query_all, DatabaseManager.Connection);
                                dataTable = new DataTable();

                                // Đổ dữ liệu từ Oracle vào DataTable
                                dataAdapter.Fill(dataTable);

                                // Đặt DataTable là nguồn dữ liệu cho DataGridView
                                data_nhanvien.DataSource = dataTable;

                            }
                        }

                        // Kiểm tra kết nối


                    }



                }
                catch (OracleException ex)
                {
                    // Xử lý lỗi khi thực thi truy vấn
                    MessageBox.Show("Lỗi truy vấn SQL: " + ex.Message);
                }
            }

        }

        private void data_nhanvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string manv = tb_manv_nv.Text;
            string tennv = tb_tennv_nv.Text;
            string phai;
            string vaitro;
            DateTime ngaysinh;

            if (dd_phai_nv.SelectedItem != null)
            {
                phai = dd_phai_nv.SelectedItem.ToString();
                // Sử dụng giá trị selectedValue trong các xử lý dữ liệu khác
            }

            if (dt_ngaysinh_nv.Value != null)
            {
                ngaysinh = dt_ngaysinh_nv.Value;
                // Sử dụng giá trị selectedValue trong các xử lý dữ liệu khác
            }

            string diachi = tb_diachi_nv.Text;
            string sodt = tb_sodt_nv.Text;
            string luong = tb_luong_nv.Text;
            string phucap = tb_phucap_nv.Text;

            if (cbb_vaitro_nv.SelectedItem != null)
            {
                vaitro = cbb_vaitro_nv.SelectedItem.ToString();
                // Sử dụng giá trị selectedValue trong các xử lý dữ liệu khác
            }

            string manql = tb_manql_nv.Text;
            string phg = tb_phg_nv.Text;

        }

        private void dt_ngaysinh_nv_ValueChanged(object sender, EventArgs e)
        {
            if (dt_ngaysinh_nv.Value == dt_ngaysinh_nv.MinDate)
            {
                dt_ngaysinh_nv.CustomFormat = " "; // Hiển thị giá trị null nếu giá trị DateTimePicker bằng giá trị MinDate
            }
            else
            {
                dt_ngaysinh_nv.CustomFormat = "dd/MM/yyyy"; // Đặt format ngày tháng mong muốn
            }
        }
    }
}
