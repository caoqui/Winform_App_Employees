using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MyApp;


namespace WindowsFormsApp
{
    public partial class Grant_user : Form
    {
        public Grant_user()
        {
            InitializeComponent();

            comboBox1.Items.Add("INSERT");
            comboBox1.Items.Add("SELECT");
            comboBox1.Items.Add("UPDATE");
            comboBox1.Items.Add("DELETE");

/*            comboBox2.Items.Add("GRANTEE");
            comboBox2.Items.Add("TABLE_NAME");
            comboBox2.Items.Add("PRIVILEGE");
            comboBox2.Items.Add("GRANTABLE");*/

            cbb_bang_grant_user.Items.Add("NHANVIEN");
            cbb_bang_grant_user.Items.Add("PHONGBAN");
            cbb_bang_grant_user.Items.Add("DEAN");
            cbb_bang_grant_user.Items.Add("PHANCONG");

            cbb_bang_grant_user.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;


        }

        private void Grant_user_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_home_grant_user_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox_username_grant.Text;
            string quyen = comboBox1.SelectedItem.ToString();
            string bang;

            if (cbb_bang_grant_user.SelectedItem != null)
            {
                bang = cbb_bang_grant_user.SelectedItem.ToString();
                // Sử dụng giá trị selectedValue trong các xử lý dữ liệu khác
            } else
            {
                bang = "NONE";
            }
            string thuoctinh = comboBox2.SelectedItem.ToString();

            string allowgrant;

            if (checkBox_grant.Checked)
            {
                // Checkbox đã được chọn
                allowgrant = " WITH GRANT OPTION";
            }
            else
            {
                // Checkbox không được chọn
                allowgrant = "";
            }


            OracleHelper.Grant(username, quyen, bang, thuoctinh, allowgrant);

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btn_revoke_grant_Click(object sender, EventArgs e)
        {
            string username = textBox_username_grant.Text;
            string quyen = comboBox1.SelectedItem.ToString();
            string bang;

            if (cbb_bang_grant_user.SelectedItem != null)
            {
                bang = cbb_bang_grant_user.SelectedItem.ToString();
                // Sử dụng giá trị selectedValue trong các xử lý dữ liệu khác
            }
            else
            {
                bang = "NONE";
            }
            string thuoctinh = comboBox2.SelectedItem.ToString();

            OracleHelper.Revoke(username, quyen, bang, thuoctinh);
        }

        private void cbb_bang_grant_user_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa tất cả các tùy chọn hiện có trong ComboBox 2
            comboBox2.Items.Clear();

            // Kiểm tra lựa chọn hiện tại của ComboBox 1 và thêm tùy chọn tương ứng vào ComboBox 2
            if (cbb_bang_grant_user.SelectedIndex == 0)
            {
                comboBox2.Items.Clear();
                // Tùy chọn 1 của ComboBox 1 đã được chọn, cập nhật tùy chọn của ComboBox 2
                comboBox2.Items.Add("MANV");
                comboBox2.Items.Add("TENNV");
                comboBox2.Items.Add("PHAI");
                comboBox2.Items.Add("NGAYSINH");
                comboBox2.Items.Add("DIACHI");
                comboBox2.Items.Add("SODT");
                comboBox2.Items.Add("LUONG");
                comboBox2.Items.Add("PHUCAP");
                comboBox2.Items.Add("VAITRO");
                comboBox2.Items.Add("MANQL");
                comboBox2.Items.Add("PHG");
            }
            else if (cbb_bang_grant_user.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                // Tùy chọn 2 của ComboBox 1 đã được chọn, cập nhật tùy chọn của ComboBox 2
                comboBox2.Items.Add("MAPB");
                comboBox2.Items.Add("TENPHB");
                comboBox2.Items.Add("TRPHG");
            }
            else if (cbb_bang_grant_user.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                // Tùy chọn 2 của ComboBox 1 đã được chọn, cập nhật tùy chọn của ComboBox 2
                comboBox2.Items.Add("MADA");
                comboBox2.Items.Add("TENDA");
                comboBox2.Items.Add("NGAYBD");
                comboBox2.Items.Add("PHONG");
            }
            else if (cbb_bang_grant_user.SelectedIndex == 3)
            {
                comboBox2.Items.Clear();
                // Tùy chọn 2 của ComboBox 1 đã được chọn, cập nhật tùy chọn của ComboBox 2
                comboBox2.Items.Add("MANV");
                comboBox2.Items.Add("MADA");
                comboBox2.Items.Add("THOIGIAN");
            }
            // Có thể thêm các trường hợp khác tùy thuộc vào lựa chọn của ComboBox 1

            // Chọn tùy chọn đầu tiên trong ComboBox 2 (nếu có)
            if (comboBox2.Items.Count > 0)
            {
                comboBox2.SelectedIndex = 0;
            }
        }
    }
}
