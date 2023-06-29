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
                        if (result == "Trưởng phòng")
                        {
                            query_all = "SELECT * FROM ATBM.TP_PC_VIEW";
                            if (DatabaseManager.Connection != null)
                            {
                                // Tạo câu truy vấn


                                // Khởi tạo DataAdapter và DataTable
                                dataAdapter = new OracleDataAdapter(query_all, DatabaseManager.Connection);
                                dataTable = new DataTable();

                                // Đổ dữ liệu từ Oracle vào DataTable
                                dataAdapter.Fill(dataTable);

                                // Đặt DataTable là nguồn dữ liệu cho DataGridView
                                data_phancong.DataSource = dataTable;

                            }
                        }
                        else if (result == "Tài chính")
                        {
                            query_all = "SELECT * FROM ATBM.PHANCONG";
                            if (DatabaseManager.Connection != null)
                            {
                                // Tạo câu truy vấn


                                // Khởi tạo DataAdapter và DataTable
                                dataAdapter = new OracleDataAdapter(query_all, DatabaseManager.Connection);
                                dataTable = new DataTable();

                                // Đổ dữ liệu từ Oracle vào DataTable
                                dataAdapter.Fill(dataTable);

                                // Đặt DataTable là nguồn dữ liệu cho DataGridView
                                data_phancong.DataSource = dataTable;

                            }
                        }
                        else if (result == "QL Trực tiếp")
                        {
                            query_all = "SELECT * FROM ATBM.QL_PC_VIEW";
                            if (DatabaseManager.Connection != null)
                            {
                                // Tạo câu truy vấn


                                // Khởi tạo DataAdapter và DataTable
                                dataAdapter = new OracleDataAdapter(query_all, DatabaseManager.Connection);
                                dataTable = new DataTable();

                                // Đổ dữ liệu từ Oracle vào DataTable
                                dataAdapter.Fill(dataTable);

                                // Đặt DataTable là nguồn dữ liệu cho DataGridView
                                data_phancong.DataSource = dataTable;

                            }
                        } else
                        {
                            query_all = "SELECT * FROM ATBM.NV_PC_VIEW";

                            if (DatabaseManager.Connection != null)
                            {
                                // Tạo câu truy vấn


                                // Khởi tạo DataAdapter và DataTable
                                dataAdapter = new OracleDataAdapter(query_all, DatabaseManager.Connection);
                                dataTable = new DataTable();

                                // Đổ dữ liệu từ Oracle vào DataTable
                                dataAdapter.Fill(dataTable);

                                // Đặt DataTable là nguồn dữ liệu cho DataGridView
                                data_phancong.DataSource = dataTable;

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



            if (DatabaseManager.Connection != null)
            {

                try
                {
                    // Tạo câu truy vấn
                    int manv = Int32.Parse(tb_manv_pc.Text);
                    string mada = tb_mada_pc.Text;

                    string thoigian = dt_thoigian_pc.Value.ToString("yyyy-MM-dd").Substring(0, 10);

                    string query = string.Format(@"INSERT INTO ATBM.PHANCONG(MANV, MADA, THOIGIAN) VALUES ({0},'{1}',TO_DATE('{2}','yyyy-MM-dd'))", manv, mada, thoigian);


                    // Khởi tạo DataAdapter và DataTable
                    dataAdapter = new OracleDataAdapter(query, DatabaseManager.Connection);
                    dataTable = new DataTable();

                    MessageBox.Show(query);
                    MessageBox.Show("Thêm phân công thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERR: " + ex.Message);
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Kiểm tra kết nối
            if (DatabaseManager.Connection != null)
            {

                try
                {
                    // Tạo câu truy vấn
                    string mada = tb_mada_pc.Text;
                    int manv = Int32.Parse(tb_manv_pc.Text);

                    string query = @"DELETE FROM ATBM.PHANCONG WHERE MADA=:mada AND MANV=:MANV";
                    OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                    command.Parameters.Add(":mada", OracleDbType.Varchar2).Value = mada;
                    command.Parameters.Add(":manv", OracleDbType.Int32).Value = manv;

                    int rowsAffected = command.ExecuteNonQuery();


                    MessageBox.Show("Xóa phân công thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERR: " + ex.Message);
                }

            }
            }
        }
}
