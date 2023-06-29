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

            dt_ngaybd_da.CustomFormat = ""; // Đặt format thành một khoảng trắng để hiển thị giá trị null
            dt_ngaybd_da.Format = DateTimePickerFormat.Custom;

            dt_ngaybd_da.ValueChanged += dt_ngaybd_da_ValueChanged;
        }

        private void Dean_Load(object sender, EventArgs e)
        {
            if (DatabaseManager.Connection != null)
            {
                try
                {
                  
                    string query_all = "SELECT * FROM ATBM.DEAN";
                    dataAdapter = new OracleDataAdapter(query_all, DatabaseManager.Connection);
                    dataTable = new DataTable();

                    // Đổ dữ liệu từ Oracle vào DataTable
                    dataAdapter.Fill(dataTable);

                    // Đặt DataTable là nguồn dữ liệu cho DataGridView
                    data_dean.DataSource = dataTable;

                   
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
            


            // Kiểm tra kết nối
            if (DatabaseManager.Connection != null)
            {

                try
                {
                    // Tạo câu truy vấn
                    string mada = tb_mada_da.Text;
                    string tenda = tb_tenda_da.Text;

                    string ngaybd = dt_ngaybd_da.Value.ToString("yyyy-MM-dd").Substring(0, 10);
                    int truongda = Int32.Parse(tb_truongda_da.Text);

/*                    if (dt_ngaybd_da.Value != null)
                    {
                        ngaybd = dt_ngaybd_da.Value;
                        // Sử dụng giá trị selectedValue trong các xử lý dữ liệu khác
                    }*/

                    string phong = tb_phong_da.Text;

                    string query = string.Format(@"INSERT INTO ATBM.DEAN(MADA, TENDA,  NGAYBD, PHONG, TRUONGDA) VALUES ('{0}','{1}',TO_DATE('{2}','yyyy-MM-dd'), {3}, {4})", mada, tenda, ngaybd, phong, truongda);


                    // Khởi tạo DataAdapter và DataTable
                    dataAdapter = new OracleDataAdapter(query, DatabaseManager.Connection);
                    dataTable = new DataTable();


                    MessageBox.Show("Thêm đề án thành công!");

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
                    string mada = tb_mada_da.Text;

                    /*string query = string.Format(@"DELETE FROM ATBM.DEAN WHERE MADA={0}", mada);


                    // Khởi tạo DataAdapter và DataTable
                    dataAdapter = new OracleDataAdapter(query, DatabaseManager.Connection);
                    dataTable = new DataTable();*/
                    string query = @"DELETE FROM ATBM.DEAN WHERE MADA=:mada";
                    OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                    command.Parameters.Add(":mada", OracleDbType.Varchar2).Value = mada;

                    int rowsAffected = command.ExecuteNonQuery();


                    MessageBox.Show("Xóa đề án thành công!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERR: " + ex.Message);
                }



            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mada = tb_mada_da.Text;
            string tenda = tb_tenda_da.Text;
            string phong = tb_phong_da.Text;
            string ngaybd = dt_ngaybd_da.Value.ToString("yyyy-MM-dd").Substring(0, 10);
            int truongda = Int32.Parse(tb_truongda_da.Text);
            // ten nhan vien
            if (tenda.Length > 0)
            {
                try
                {
                    string query = @"UPDATE ATBM.DEAN SET tenda = :tenda WHERE mada = :mada";
                    OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                    command.Parameters.Add(":mada", OracleDbType.Varchar2).Value = mada;
                    command.Parameters.Add(":tenda", OracleDbType.Varchar2).Value = tenda;
                    int rowsAffected = command.ExecuteNonQuery();

                    /*MessageBox.Show("Đã cập nhật tên nhân viên thành công!");*/
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("cập tên đề án  thất bại.");
                    MessageBox.Show("Err: " + ex.Message);
                }
            }
            // cap nhat gioi tinh 
            if (phong != "" && phong != null)
            {
                try
                {
                    string query = @"UPDATE ATBM.DEAN SET phong = :phong WHERE mada = :mada";
                    OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                    command.Parameters.Add(":mada", OracleDbType.Varchar2).Value = mada;
                    command.Parameters.Add(":phong", OracleDbType.Varchar2).Value = phong;
                    int rowsAffected = command.ExecuteNonQuery();

                    /*MessageBox.Show("Đã cập nhật giới tính nhân viên thành công!");*/
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("cập phòng thất bại.");
                    MessageBox.Show("Err: " + ex.Message);
                }
            }
            // cap nhat sinh nhat 
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("yyyy-MM-dd");
            if (ngaybd.Length > 4 && ngaybd != formattedDate)
            {
                MessageBox.Show(ngaybd);
                try
                {
                    string query = @"UPDATE ATBM.DEAN SET ngaybd = TO_DATE(:ngaybd,'yyyy-MM-dd') WHERE mada = :mada";
                    OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                    command.Parameters.Add(":ngaybd", OracleDbType.Varchar2).Value = ngaybd;
                    command.Parameters.Add(":mada", OracleDbType.Varchar2).Value = mada;
                    int rowsAffected = command.ExecuteNonQuery();

                    /*MessageBox.Show("Đã cập nhật giới tính nhân viên thành công!");*/
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("cập nhất ngày bắt đầu thất bại.");
                    MessageBox.Show("Err: "+ ex.Message);
                }
            }
            // cap nhat gioi tinh 
            if (truongda > 0)
            {
                try
                {
                    string query = @"UPDATE ATBM.DEAN SET truongda = :truongda WHERE mada = :mada";
                    OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                    command.Parameters.Add(":mada", OracleDbType.Varchar2).Value = mada;
                    command.Parameters.Add(":truongda", OracleDbType.Int32).Value = truongda;
                    int rowsAffected = command.ExecuteNonQuery();

                    /*MessageBox.Show("Đã cập nhật giới tính nhân viên thành công!");*/
                }
                catch (OracleException ex)
                {
                    MessageBox.Show("cập trưởng đề án thất bại.");
                    MessageBox.Show("Err: " + ex.Message);
                }
            }
        }
    }
    
}
