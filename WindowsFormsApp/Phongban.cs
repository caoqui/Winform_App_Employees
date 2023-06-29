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

                string query = "SELECT * FROM ATBM.Phongban";


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
            int trphg = Int32.Parse(tb_trphg_pb.Text);

            // cap nhat ten pb
            if (DatabaseManager.Connection != null)
            {
        
                if (tenpb.Length > 0)
                {
                    try
                    {
                        string query = @"UPDATE ATBM.PHONGBAN SET tenpb = :tenpb WHERE mapb = :mapb";
                        OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                        command.Parameters.Add(":tenpb", OracleDbType.Varchar2).Value = tenpb;
                        command.Parameters.Add(":mapb", OracleDbType.Varchar2).Value = mapb;
                        int rowsAffected = command.ExecuteNonQuery();

                        /*MessageBox.Show("Đã cập nhật tên nhân viên thành công!");*/
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("cập nhật tên phòng ban thất bại.");
                    }
                }
            }
            // cap nhat trphg
            if (DatabaseManager.Connection != null)
            {

                if (trphg > 0)
                {
                    try
                    {
                        string query = @"UPDATE ATBM.PHONGBAN SET trphg = :trphg WHERE mapb = :mapb";
                        OracleCommand command = new OracleCommand(query, DatabaseManager.Connection);
                        command.Parameters.Add(":trphg", OracleDbType.Int32).Value = trphg;
                        command.Parameters.Add(":mapb", OracleDbType.Varchar2).Value = mapb;
                        int rowsAffected = command.ExecuteNonQuery();

                        /*MessageBox.Show("Đã cập nhật tên nhân viên thành công!");*/
                    }
                    catch (OracleException ex)
                    {
                        MessageBox.Show("cập nhật trưởng phòng ban thất bại.");
                    }
                }
            }
        }

        private void bt_them_phongban_Click(object sender, EventArgs e)
        {



            // Kiểm tra kết nối
            if (DatabaseManager.Connection != null)
            {
                // Tạo câu truy vấn
                try
                {
                    string mapb = tb_mapb_pb.Text;
                    string tenpb = tb_tenpb_pb.Text;
                    int trphg = Int32.Parse(tb_trphg_pb.Text);

                    string query = string.Format(@"INSERT INTO ATBM.PHONGBAN(MAPB, TENPB,  TRPHG) VALUES ('{0}','{1}',{2})", mapb, tenpb, trphg);


                    // Khởi tạo DataAdapter và DataTable
                    dataAdapter = new OracleDataAdapter(query, DatabaseManager.Connection);
                    dataTable = new DataTable();

                    // Đổ dữ liệu từ Oracle vào DataTable
                    dataAdapter.Fill(dataTable);

                    // Đặt DataTable là nguồn dữ liệu cho DataGridView
                    data_phongban.DataSource = dataTable;
                } catch (Exception ex)
                {
                    MessageBox.Show("ERR: "+ ex.Message);
                }

                

            }
        }
    }
}
