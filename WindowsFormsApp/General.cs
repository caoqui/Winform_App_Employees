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
    public partial class General : Form
    {
        public General()
        {
            InitializeComponent();
        }

        private void button_thongtinnv_Click(object sender, EventArgs e)
        {
            Nhanvien nhanvien = new Nhanvien();
            nhanvien.Show();
            this.Hide();
        }

        private void button_thongtinpb_Click(object sender, EventArgs e)
        {
            Phongban phongban = new Phongban();
            phongban.Show();
            this.Hide();
        }

        private void button_thongtinda_Click(object sender, EventArgs e)
        {
            Dean dean = new Dean();
            dean.Show();
            this.Hide();
        }

        private void button_thongtinpc_Click(object sender, EventArgs e)
        {
            Phancong phancong = new Phancong();
            phancong.Show();
            this.Hide();
        }
    }
}
