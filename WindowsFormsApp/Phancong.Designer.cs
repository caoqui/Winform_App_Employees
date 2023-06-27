namespace WindowsFormsApp
{
    partial class Phancong
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
            this.data_phancong = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_manv_pc = new System.Windows.Forms.TextBox();
            this.tb_mada_pc = new System.Windows.Forms.TextBox();
            this.dt_thoigian_pc = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.data_phancong)).BeginInit();
            this.SuspendLayout();
            // 
            // data_phancong
            // 
            this.data_phancong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_phancong.Location = new System.Drawing.Point(46, 94);
            this.data_phancong.Name = "data_phancong";
            this.data_phancong.RowHeadersWidth = 51;
            this.data_phancong.Size = new System.Drawing.Size(500, 307);
            this.data_phancong.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(573, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 49);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(733, 324);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(891, 324);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 49);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cập nhật";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(118, 45);
            this.button4.TabIndex = 4;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(567, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã đề án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Thời gian thực hiện";
            // 
            // tb_manv_pc
            // 
            this.tb_manv_pc.Location = new System.Drawing.Point(693, 82);
            this.tb_manv_pc.Name = "tb_manv_pc";
            this.tb_manv_pc.Size = new System.Drawing.Size(223, 22);
            this.tb_manv_pc.TabIndex = 8;
            // 
            // tb_mada_pc
            // 
            this.tb_mada_pc.Location = new System.Drawing.Point(693, 148);
            this.tb_mada_pc.Name = "tb_mada_pc";
            this.tb_mada_pc.Size = new System.Drawing.Size(224, 22);
            this.tb_mada_pc.TabIndex = 9;
            // 
            // dt_thoigian_pc
            // 
            this.dt_thoigian_pc.Location = new System.Drawing.Point(694, 208);
            this.dt_thoigian_pc.Name = "dt_thoigian_pc";
            this.dt_thoigian_pc.Size = new System.Drawing.Size(223, 22);
            this.dt_thoigian_pc.TabIndex = 10;
            this.dt_thoigian_pc.ValueChanged += new System.EventHandler(this.dt_thoigian_pc_ValueChanged);
            // 
            // Phancong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 450);
            this.Controls.Add(this.dt_thoigian_pc);
            this.Controls.Add(this.tb_mada_pc);
            this.Controls.Add(this.tb_manv_pc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data_phancong);
            this.Name = "Phancong";
            this.Text = "Phancong";
            this.Load += new System.EventHandler(this.Phancong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_phancong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_phancong;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_manv_pc;
        private System.Windows.Forms.TextBox tb_mada_pc;
        private System.Windows.Forms.DateTimePicker dt_thoigian_pc;
    }
}