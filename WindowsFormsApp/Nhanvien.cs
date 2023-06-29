using Oracle.ManagedDataAccess.Client;
using System;
using System.Data;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Status;

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
                            query_all = "SELECT MANV, ATBM.DECRYPT_DATA(TENNV) TENNV, PHAI, NGAYSINH, ATBM.DECRYPT_DATA(DIACHI) DIACHI, ATBM.DECRYPT_DATA(SODT)SODT, LUONG, PHUCAP, VAITRO, MANQL, PHG FROM ATBM.NHANVIEN";
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
/*            string manv = tb_manv_nv.Text;
*/          string tennv = tb_tennv_nv.Text;
            string phai = "Male";
            string vaitro = "Nhân viên";
            string ngaysinh = "";

            if (dd_phai_nv.SelectedItem != null)
            {
                phai = dd_phai_nv.SelectedItem.ToString();
                // Sử dụng giá trị selectedValue trong các xử lý dữ liệu khác
            }

            if (dt_ngaysinh_nv.Value != null)
            {
                ngaysinh = dt_ngaysinh_nv.Value.ToString().Substring(0, 10);
                
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

            int manql = Int32.Parse(tb_manql_nv.Text);
            string phg = tb_phg_nv.Text;
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
                        /*MessageBox.Show(result);*/
                        if (result == "Nhân sự")
                        {
                            /*                            query_all = "INSERT INTO TABLE ";*/
                            query_all = string.Format(@"INSERT INTO ATBM.NHANVIEN(TENNV, PHAI,  NGAYSINH, DIACHI, SODT, VAITRO, MANQL, PHG) VALUES
( ATBM.encrypt_data(N'{0}'), '{1}',TO_DATE('{2}','DD/MM/YYYY'), ATBM.encrypt_data(N'{3}'), ATBM.encrypt_data({4}), N'{5}', {6}, '{7}')", tennv, phai, ngaysinh, diachi, sodt, vaitro, manql, phg);

                            MessageBox.Show(query_all);

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

        private void dt_ngaysinh_nv_ValueChanged(object sender, EventArgs e)
        {
            if (dt_ngaysinh_nv.Value == dt_ngaysinh_nv.MinDate)
            {
                dt_ngaysinh_nv.CustomFormat = null; // Hiển thị giá trị null nếu giá trị DateTimePicker bằng giá trị MinDate
            }
            else
            {
                dt_ngaysinh_nv.CustomFormat = "dd/MM/yyyy"; // Đặt format ngày tháng mong muốn
            }
        }

        private void btn_xoa_nv_Click(object sender, EventArgs e)
        {
        }

        private void btn_capnhat_nv_Click(object sender, EventArgs e)
        {
            string manv = tb_manv_nv.Text;
            string tennv = tb_tennv_nv.Text;
            string phai = dd_phai_nv.SelectedItem?.ToString();
            string ngaysinh = dt_ngaysinh_nv.Value.ToString("yyyy-MM-dd").Substring(0, 10);
            string diachi = tb_diachi_nv.Text;
            string sodt = tb_sodt_nv.Text;
            string luong = tb_luong_nv.Text;
            string phucap = tb_phucap_nv.Text;
            string vaitro = cbb_vaitro_nv.SelectedItem?.ToString();
            string manql = tb_manql_nv.Text;
/*            int manql;
            
            if(tb_manql_nv.Text != null || tb_manql_nv.Text != "")
            {
                manql = Int32.Parse(tb_manql_nv.Text);
            }*/


            string phg = tb_phg_nv.Text;

            if (DatabaseManager.Connection != null)
            {
                // ten nhan vien
                if (tennv.Length > 0)
                {
                    try
                    {
                        string query = @"UPDATE ATBM.NHANVIEN SET tennv = ATBM.encrypt_data(:tennv) WHERE manv = :manv";
                        OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                        command.Parameters.Add(":tennv", OracleDbType.Varchar2).Value = tennv;
                        command.Parameters.Add(":manv", OracleDbType.Int32).Value = manv;
                        int rowsAffected = command.ExecuteNonQuery();

                        /*MessageBox.Show("Đã cập nhật tên nhân viên thành công!");*/
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("cập nhất họ tên nhân viên thất bại.");
                    }
                }
                // cap nhat gioi tinh 
                if (phai == "Male" || phai == "Female")
                {
                    try
                    {
                        string query = @"UPDATE ATBM.NHANVIEN SET phai = :phai WHERE manv = :manv";
                        OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                        command.Parameters.Add(":phai", OracleDbType.Varchar2).Value = phai;
                        command.Parameters.Add(":manv", OracleDbType.Int32).Value = manv;
                        int rowsAffected = command.ExecuteNonQuery();

                        /*MessageBox.Show("Đã cập nhật giới tính nhân viên thành công!");*/
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("cập nhất giới tính  nhân viên thất bại.");
                    }
                }
                // cap nhat sinh nhat 
                DateTime currentDate = DateTime.Now;
                string formattedDate = currentDate.ToString("yyyy-MM-dd");
                if (ngaysinh.Length > 4 && ngaysinh != formattedDate)
                {
                    MessageBox.Show(ngaysinh);
                    try
                    {
                        string query = @"UPDATE ATBM.NHANVIEN SET ngaysinh = TO_DATE(:ngaysinh,'yyyy-MM-dd') WHERE manv = :manv";
                        OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                        command.Parameters.Add(":ngaysinh", OracleDbType.Varchar2).Value = ngaysinh;
                        command.Parameters.Add(":manv", OracleDbType.Int32).Value = manv;
                        int rowsAffected = command.ExecuteNonQuery();

                        /*MessageBox.Show("Đã cập nhật giới tính nhân viên thành công!");*/
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("cập nhất ngày sinh  nhân viên thất bại.");
                        MessageBox.Show("Err: ", ex.Message);
                    }
                }
            }
            // cap nhat diachi 
            if (diachi.Length > 0 && diachi != null)
            {
                try
                {
                    string query = @"UPDATE ATBM.NHANVIEN SET diachi = ATBM.encrypt_data(:diachi) WHERE manv = :manv";
                    OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                    command.Parameters.Add(":diachi", OracleDbType.Varchar2).Value = diachi;
                    command.Parameters.Add(":manv", OracleDbType.Int32).Value = manv;
                    int rowsAffected = command.ExecuteNonQuery();

                    /*MessageBox.Show("Đã cập nhật giới tính nhân viên thành công!");*/
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("cập nhất địa chỉ  nhân viên thất bại.");
                }
            }
            // cap nhat so dt 
            if (sodt.Length > 0 && sodt != null)
            {
                try
                {
                    string query = @"UPDATE ATBM.NHANVIEN SET sodt = ATBM.decrypt(:sodt) WHERE manv = :manv";
                    OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                    command.Parameters.Add(":sodt", OracleDbType.Varchar2).Value = sodt;
                    command.Parameters.Add(":manv", OracleDbType.Int32).Value = manv;
                    int rowsAffected = command.ExecuteNonQuery();

                    /*MessageBox.Show("Đã cập nhật giới tính nhân viên thành công!");*/
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("cập nhất số điện thoại  nhân viên thất bại.");
                }
            }

            // cap nhat lương 
            if (luong.Length > 0 && luong != null)
            {
                try
                {
                    string query = @"UPDATE ATBM.NHANVIEN SET luong = :luong WHERE manv = :manv";
                    OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                    command.Parameters.Add(":luong", OracleDbType.Varchar2).Value = luong;
                    command.Parameters.Add(":manv", OracleDbType.Int32).Value = manv;
                    int rowsAffected = command.ExecuteNonQuery();

                    /*MessageBox.Show("Đã cập nhật giới tính nhân viên thành công!");*/
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("cập nhất số lương  nhân viên thất bại.");
                }
            }
            // cap nhat phu cap 
            if (phucap.Length > 0 && phucap != null)
            {
                try
                {
                    string query = @"UPDATE ATBM.NHANVIEN SET phucap = :phucap WHERE manv = :manv";
                    OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                    command.Parameters.Add(":phucap", OracleDbType.Varchar2).Value = phucap;
                    command.Parameters.Add(":manv", OracleDbType.Int32).Value = manv;
                    int rowsAffected = command.ExecuteNonQuery();

                    /*MessageBox.Show("Đã cập nhật giới tính nhân viên thành công!");*/
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("cập nhật phúc lợi  nhân viên thất bại.");
                }
            }

            // cap nhat vai tro 
            if (vaitro =="Nhân viên"|| vaitro=="Nhân sự"|| vaitro=="Tài chính"|| vaitro=="Trưởng đề án"|| vaitro=="Trưởng phòng"|| vaitro=="Ql trực tiếp")
            {
                try
                {
                    string query = @"UPDATE ATBM.NHANVIEN SET vaitro = :vaitro WHERE manv = :manv";
                    OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                    command.Parameters.Add(":vaitro", OracleDbType.Varchar2).Value = vaitro;
                    command.Parameters.Add(":manv", OracleDbType.Int32).Value = manv;
                    int rowsAffected = command.ExecuteNonQuery();

                    /*MessageBox.Show("Đã cập nhật giới tính nhân viên thành công!");*/
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("cập nhật vai trò  nhân viên thất bại.");
                }
            }
            // cap nhat người quản lý
            if (manql.Length > 0 && manql != null)
            {
                try
                {
                    string query = @"UPDATE ATBM.NHANVIEN SET manql = :manql WHERE manv = :manv";
                    OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                    command.Parameters.Add(":manql", OracleDbType.Varchar2).Value = manql;
                    command.Parameters.Add(":manv", OracleDbType.Int32).Value = manv;
                    int rowsAffected = command.ExecuteNonQuery();

                    /*MessageBox.Show("Đã cập nhật giới tính nhân viên thành công!");*/
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("cập nhật nguời quản lý  nhân viên thất bại.");
                }
            }
            // cap nhat người phong
            if (phg.Length > 0 && phg != null)
            {
                try
                {
                    string query = @"UPDATE ATBM.NHANVIEN SET phg = :phg WHERE manv = :manv";
                    OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                    command.Parameters.Add(":phg", OracleDbType.Varchar2).Value = phg;
                    command.Parameters.Add(":manv", OracleDbType.Int32).Value = manv;
                    int rowsAffected = command.ExecuteNonQuery();

                    /*MessageBox.Show("Đã cập nhật giới tính nhân viên thành công!");*/
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("cập nhật phòng ban  nhân viên thất bại.");
                }
            }
        }

    }

 }
