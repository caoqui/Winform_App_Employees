namespace WindowsFormsApp
{
    partial class Dean
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
            this.data_dean = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_mada_da = new System.Windows.Forms.TextBox();
            this.tb_tenda_da = new System.Windows.Forms.TextBox();
            this.tb_phong_da = new System.Windows.Forms.TextBox();
            this.dt_ngaybd_da = new System.Windows.Forms.DateTimePicker();
            this.tb_truongda_da = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_dean)).BeginInit();
            this.SuspendLayout();
            // 
            // data_dean
            // 
            this.data_dean.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_dean.Location = new System.Drawing.Point(44, 80);
            this.data_dean.Name = "data_dean";
            this.data_dean.RowHeadersWidth = 51;
            this.data_dean.Size = new System.Drawing.Size(488, 327);
            this.data_dean.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(554, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Thêm";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(733, 344);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 47);
            this.button2.TabIndex = 2;
            this.button2.Text = "Xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(925, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 48);
            this.button3.TabIndex = 3;
            this.button3.Text = "Cập nhật";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(16, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(130, 41);
            this.button4.TabIndex = 4;
            this.button4.Text = "Home";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã đề án";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên đề án";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(612, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ngày thực hiện";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(612, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Mã phòng";
            // 
            // tb_mada_da
            // 
            this.tb_mada_da.Location = new System.Drawing.Point(725, 70);
            this.tb_mada_da.Name = "tb_mada_da";
            this.tb_mada_da.Size = new System.Drawing.Size(272, 22);
            this.tb_mada_da.TabIndex = 9;
            // 
            // tb_tenda_da
            // 
            this.tb_tenda_da.Location = new System.Drawing.Point(725, 126);
            this.tb_tenda_da.Name = "tb_tenda_da";
            this.tb_tenda_da.Size = new System.Drawing.Size(272, 22);
            this.tb_tenda_da.TabIndex = 10;
            // 
            // tb_phong_da
            // 
            this.tb_phong_da.Location = new System.Drawing.Point(725, 235);
            this.tb_phong_da.Name = "tb_phong_da";
            this.tb_phong_da.Size = new System.Drawing.Size(272, 22);
            this.tb_phong_da.TabIndex = 12;
            // 
            // dt_ngaybd_da
            // 
            this.dt_ngaybd_da.Location = new System.Drawing.Point(725, 185);
            this.dt_ngaybd_da.Name = "dt_ngaybd_da";
            this.dt_ngaybd_da.Size = new System.Drawing.Size(272, 22);
            this.dt_ngaybd_da.TabIndex = 13;
            this.dt_ngaybd_da.ValueChanged += new System.EventHandler(this.dt_ngaybd_da_ValueChanged);
            // 
            // tb_truongda_da
            // 
            this.tb_truongda_da.Location = new System.Drawing.Point(733, 282);
            this.tb_truongda_da.Name = "tb_truongda_da";
            this.tb_truongda_da.Size = new System.Drawing.Size(263, 22);
            this.tb_truongda_da.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Trưởng đề án";
            // 
            // Dean
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_truongda_da);
            this.Controls.Add(this.dt_ngaybd_da);
            this.Controls.Add(this.tb_phong_da);
            this.Controls.Add(this.tb_tenda_da);
            this.Controls.Add(this.tb_mada_da);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.data_dean);
            this.Name = "Dean";
            this.Text = "Dean";
            this.Load += new System.EventHandler(this.Dean_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_dean)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_dean;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_mada_da;
        private System.Windows.Forms.TextBox tb_tenda_da;
        private System.Windows.Forms.TextBox tb_phong_da;
        private System.Windows.Forms.DateTimePicker dt_ngaybd_da;
        private System.Windows.Forms.TextBox tb_truongda_da;
        private System.Windows.Forms.Label label5;
    }
}