﻿namespace WindowsFormsApp
{
    partial class Nhanvien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_nhanvien = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.tb_manv_nv = new System.Windows.Forms.TextBox();
            this.tb_tennv_nv = new System.Windows.Forms.TextBox();
            this.tb_phai_nv = new System.Windows.Forms.TextBox();
            this.tb_diachi_nv = new System.Windows.Forms.TextBox();
            this.tb_phg_nv = new System.Windows.Forms.TextBox();
            this.tb_manql_nv = new System.Windows.Forms.TextBox();
            this.tb_vaitro_nv = new System.Windows.Forms.TextBox();
            this.tb_luong_nv = new System.Windows.Forms.TextBox();
            this.tb_phucap_nv = new System.Windows.Forms.TextBox();
            this.lb_manv = new System.Windows.Forms.Label();
            this.lb_temnv = new System.Windows.Forms.Label();
            this.lb_phai = new System.Windows.Forms.Label();
            this.lb_ngaysinh = new System.Windows.Forms.Label();
            this.lb_diachi = new System.Windows.Forms.Label();
            this.lb_phg = new System.Windows.Forms.Label();
            this.lb_manql = new System.Windows.Forms.Label();
            this.lb_vaitro = new System.Windows.Forms.Label();
            this.lb_phucap = new System.Windows.Forms.Label();
            this.lb_luong = new System.Windows.Forms.Label();
            this.lb_sodt = new System.Windows.Forms.Label();
            this.tb_sodt_nv = new System.Windows.Forms.TextBox();
            this.dt_ngaysinh_nv = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.data_nhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // data_nhanvien
            // 
            this.data_nhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_nhanvien.Location = new System.Drawing.Point(27, 64);
            this.data_nhanvien.Name = "data_nhanvien";
            this.data_nhanvien.RowHeadersWidth = 51;
            this.data_nhanvien.RowTemplate.Height = 24;
            this.data_nhanvien.Size = new System.Drawing.Size(448, 355);
            this.data_nhanvien.TabIndex = 0;
            this.data_nhanvien.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_nhanvien_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(710, 443);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 44);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(921, 443);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 44);
            this.button4.TabIndex = 4;
            this.button4.Text = "Cập nhật";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(19, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 41);
            this.button5.TabIndex = 5;
            this.button5.Text = "Home";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tb_manv_nv
            // 
            this.tb_manv_nv.Location = new System.Drawing.Point(593, 38);
            this.tb_manv_nv.Name = "tb_manv_nv";
            this.tb_manv_nv.Size = new System.Drawing.Size(239, 22);
            this.tb_manv_nv.TabIndex = 6;
            // 
            // tb_tennv_nv
            // 
            this.tb_tennv_nv.Location = new System.Drawing.Point(593, 88);
            this.tb_tennv_nv.Name = "tb_tennv_nv";
            this.tb_tennv_nv.Size = new System.Drawing.Size(239, 22);
            this.tb_tennv_nv.TabIndex = 7;
            // 
            // tb_phai_nv
            // 
            this.tb_phai_nv.Location = new System.Drawing.Point(593, 137);
            this.tb_phai_nv.Name = "tb_phai_nv";
            this.tb_phai_nv.Size = new System.Drawing.Size(239, 22);
            this.tb_phai_nv.TabIndex = 8;
            // 
            // tb_diachi_nv
            // 
            this.tb_diachi_nv.Location = new System.Drawing.Point(593, 229);
            this.tb_diachi_nv.Name = "tb_diachi_nv";
            this.tb_diachi_nv.Size = new System.Drawing.Size(239, 22);
            this.tb_diachi_nv.TabIndex = 10;
            // 
            // tb_phg_nv
            // 
            this.tb_phg_nv.Location = new System.Drawing.Point(956, 229);
            this.tb_phg_nv.Name = "tb_phg_nv";
            this.tb_phg_nv.Size = new System.Drawing.Size(223, 22);
            this.tb_phg_nv.TabIndex = 11;
            // 
            // tb_manql_nv
            // 
            this.tb_manql_nv.Location = new System.Drawing.Point(956, 178);
            this.tb_manql_nv.Name = "tb_manql_nv";
            this.tb_manql_nv.Size = new System.Drawing.Size(223, 22);
            this.tb_manql_nv.TabIndex = 12;
            // 
            // tb_vaitro_nv
            // 
            this.tb_vaitro_nv.Location = new System.Drawing.Point(956, 126);
            this.tb_vaitro_nv.Name = "tb_vaitro_nv";
            this.tb_vaitro_nv.Size = new System.Drawing.Size(223, 22);
            this.tb_vaitro_nv.TabIndex = 13;
            // 
            // tb_luong_nv
            // 
            this.tb_luong_nv.Location = new System.Drawing.Point(956, 38);
            this.tb_luong_nv.Name = "tb_luong_nv";
            this.tb_luong_nv.Size = new System.Drawing.Size(223, 22);
            this.tb_luong_nv.TabIndex = 14;
            // 
            // tb_phucap_nv
            // 
            this.tb_phucap_nv.Location = new System.Drawing.Point(956, 88);
            this.tb_phucap_nv.Name = "tb_phucap_nv";
            this.tb_phucap_nv.Size = new System.Drawing.Size(223, 22);
            this.tb_phucap_nv.TabIndex = 15;
            // 
            // lb_manv
            // 
            this.lb_manv.AutoSize = true;
            this.lb_manv.Location = new System.Drawing.Point(491, 41);
            this.lb_manv.Name = "lb_manv";
            this.lb_manv.Size = new System.Drawing.Size(86, 16);
            this.lb_manv.TabIndex = 16;
            this.lb_manv.Text = "Mã nhân viên";
            // 
            // lb_temnv
            // 
            this.lb_temnv.AutoSize = true;
            this.lb_temnv.Location = new System.Drawing.Point(491, 94);
            this.lb_temnv.Name = "lb_temnv";
            this.lb_temnv.Size = new System.Drawing.Size(91, 16);
            this.lb_temnv.TabIndex = 17;
            this.lb_temnv.Text = "Tên nhân viên";
            // 
            // lb_phai
            // 
            this.lb_phai.AutoSize = true;
            this.lb_phai.Location = new System.Drawing.Point(491, 140);
            this.lb_phai.Name = "lb_phai";
            this.lb_phai.Size = new System.Drawing.Size(54, 16);
            this.lb_phai.TabIndex = 18;
            this.lb_phai.Text = "Giới tính";
            // 
            // lb_ngaysinh
            // 
            this.lb_ngaysinh.AutoSize = true;
            this.lb_ngaysinh.Location = new System.Drawing.Point(491, 184);
            this.lb_ngaysinh.Name = "lb_ngaysinh";
            this.lb_ngaysinh.Size = new System.Drawing.Size(61, 16);
            this.lb_ngaysinh.TabIndex = 19;
            this.lb_ngaysinh.Text = "Sinh nhật";
            // 
            // lb_diachi
            // 
            this.lb_diachi.AutoSize = true;
            this.lb_diachi.Location = new System.Drawing.Point(491, 232);
            this.lb_diachi.Name = "lb_diachi";
            this.lb_diachi.Size = new System.Drawing.Size(39, 16);
            this.lb_diachi.TabIndex = 20;
            this.lb_diachi.Text = "Nơi ở";
            // 
            // lb_phg
            // 
            this.lb_phg.AutoSize = true;
            this.lb_phg.Location = new System.Drawing.Point(858, 232);
            this.lb_phg.Name = "lb_phg";
            this.lb_phg.Size = new System.Drawing.Size(72, 16);
            this.lb_phg.TabIndex = 21;
            this.lb_phg.Text = "Phòng ban";
            // 
            // lb_manql
            // 
            this.lb_manql.AutoSize = true;
            this.lb_manql.Location = new System.Drawing.Point(858, 184);
            this.lb_manql.Name = "lb_manql";
            this.lb_manql.Size = new System.Drawing.Size(89, 16);
            this.lb_manql.TabIndex = 22;
            this.lb_manql.Text = "Người quản lý";
            // 
            // lb_vaitro
            // 
            this.lb_vaitro.AutoSize = true;
            this.lb_vaitro.Location = new System.Drawing.Point(858, 132);
            this.lb_vaitro.Name = "lb_vaitro";
            this.lb_vaitro.Size = new System.Drawing.Size(45, 16);
            this.lb_vaitro.TabIndex = 23;
            this.lb_vaitro.Text = "Vai trò";
            // 
            // lb_phucap
            // 
            this.lb_phucap.AutoSize = true;
            this.lb_phucap.Location = new System.Drawing.Point(858, 91);
            this.lb_phucap.Name = "lb_phucap";
            this.lb_phucap.Size = new System.Drawing.Size(54, 16);
            this.lb_phucap.TabIndex = 24;
            this.lb_phucap.Text = "Phúc lợi";
            // 
            // lb_luong
            // 
            this.lb_luong.AutoSize = true;
            this.lb_luong.Location = new System.Drawing.Point(859, 41);
            this.lb_luong.Name = "lb_luong";
            this.lb_luong.Size = new System.Drawing.Size(44, 16);
            this.lb_luong.TabIndex = 25;
            this.lb_luong.Text = "Luong";
            // 
            // lb_sodt
            // 
            this.lb_sodt.AutoSize = true;
            this.lb_sodt.Location = new System.Drawing.Point(491, 289);
            this.lb_sodt.Name = "lb_sodt";
            this.lb_sodt.Size = new System.Drawing.Size(85, 16);
            this.lb_sodt.TabIndex = 26;
            this.lb_sodt.Text = "Số điện thoại";
            // 
            // tb_sodt_nv
            // 
            this.tb_sodt_nv.Location = new System.Drawing.Point(594, 286);
            this.tb_sodt_nv.Name = "tb_sodt_nv";
            this.tb_sodt_nv.Size = new System.Drawing.Size(238, 22);
            this.tb_sodt_nv.TabIndex = 27;
            // 
            // dt_ngaysinh_nv
            // 
            this.dt_ngaysinh_nv.Location = new System.Drawing.Point(596, 184);
            this.dt_ngaysinh_nv.Name = "dt_ngaysinh_nv";
            this.dt_ngaysinh_nv.Size = new System.Drawing.Size(236, 22);
            this.dt_ngaysinh_nv.TabIndex = 28;
            // 
            // Nhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1263, 511);
            this.Controls.Add(this.dt_ngaysinh_nv);
            this.Controls.Add(this.tb_sodt_nv);
            this.Controls.Add(this.lb_sodt);
            this.Controls.Add(this.lb_luong);
            this.Controls.Add(this.lb_phucap);
            this.Controls.Add(this.lb_vaitro);
            this.Controls.Add(this.lb_manql);
            this.Controls.Add(this.lb_phg);
            this.Controls.Add(this.lb_diachi);
            this.Controls.Add(this.lb_ngaysinh);
            this.Controls.Add(this.lb_phai);
            this.Controls.Add(this.lb_temnv);
            this.Controls.Add(this.lb_manv);
            this.Controls.Add(this.tb_phucap_nv);
            this.Controls.Add(this.tb_luong_nv);
            this.Controls.Add(this.tb_vaitro_nv);
            this.Controls.Add(this.tb_manql_nv);
            this.Controls.Add(this.tb_phg_nv);
            this.Controls.Add(this.tb_diachi_nv);
            this.Controls.Add(this.tb_phai_nv);
            this.Controls.Add(this.tb_tennv_nv);
            this.Controls.Add(this.tb_manv_nv);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data_nhanvien);
            this.Name = "Nhanvien";
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.Nhanvien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_nhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_nhanvien;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox tb_manv_nv;
        private System.Windows.Forms.TextBox tb_tennv_nv;
        private System.Windows.Forms.TextBox tb_phai_nv;
        private System.Windows.Forms.TextBox tb_diachi_nv;
        private System.Windows.Forms.TextBox tb_phg_nv;
        private System.Windows.Forms.TextBox tb_manql_nv;
        private System.Windows.Forms.TextBox tb_vaitro_nv;
        private System.Windows.Forms.TextBox tb_luong_nv;
        private System.Windows.Forms.TextBox tb_phucap_nv;
        private System.Windows.Forms.Label lb_manv;
        private System.Windows.Forms.Label lb_temnv;
        private System.Windows.Forms.Label lb_phai;
        private System.Windows.Forms.Label lb_ngaysinh;
        private System.Windows.Forms.Label lb_diachi;
        private System.Windows.Forms.Label lb_phg;
        private System.Windows.Forms.Label lb_manql;
        private System.Windows.Forms.Label lb_vaitro;
        private System.Windows.Forms.Label lb_phucap;
        private System.Windows.Forms.Label lb_luong;
        private System.Windows.Forms.Label lb_sodt;
        private System.Windows.Forms.TextBox tb_sodt_nv;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh_nv;
    }
}