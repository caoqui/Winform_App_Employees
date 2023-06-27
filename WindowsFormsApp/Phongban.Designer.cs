namespace WindowsFormsApp
{
    partial class Phongban
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
            this.data_phongban = new System.Windows.Forms.DataGridView();
            this.btn_update_pb = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_mapb_pb = new System.Windows.Forms.TextBox();
            this.tb_tenpb_pb = new System.Windows.Forms.TextBox();
            this.tb_trphg_pb = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_phongban)).BeginInit();
            this.SuspendLayout();
            // 
            // data_phongban
            // 
            this.data_phongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_phongban.Location = new System.Drawing.Point(45, 74);
            this.data_phongban.Name = "data_phongban";
            this.data_phongban.RowHeadersWidth = 51;
            this.data_phongban.Size = new System.Drawing.Size(537, 306);
            this.data_phongban.TabIndex = 0;
            // 
            // btn_update_pb
            // 
            this.btn_update_pb.Location = new System.Drawing.Point(825, 328);
            this.btn_update_pb.Name = "btn_update_pb";
            this.btn_update_pb.Size = new System.Drawing.Size(142, 52);
            this.btn_update_pb.TabIndex = 2;
            this.btn_update_pb.Text = "Cập nhật";
            this.btn_update_pb.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 33);
            this.button2.TabIndex = 3;
            this.button2.Text = "Home";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(649, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã phòng ban";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(649, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tên phòng ban";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(649, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trưởng phòng";
            // 
            // tb_mapb_pb
            // 
            this.tb_mapb_pb.Location = new System.Drawing.Point(760, 80);
            this.tb_mapb_pb.Name = "tb_mapb_pb";
            this.tb_mapb_pb.Size = new System.Drawing.Size(240, 22);
            this.tb_mapb_pb.TabIndex = 7;
            // 
            // tb_tenpb_pb
            // 
            this.tb_tenpb_pb.Location = new System.Drawing.Point(760, 158);
            this.tb_tenpb_pb.Name = "tb_tenpb_pb";
            this.tb_tenpb_pb.Size = new System.Drawing.Size(240, 22);
            this.tb_tenpb_pb.TabIndex = 8;
            // 
            // tb_trphg_pb
            // 
            this.tb_trphg_pb.Location = new System.Drawing.Point(760, 233);
            this.tb_trphg_pb.Name = "tb_trphg_pb";
            this.tb_trphg_pb.Size = new System.Drawing.Size(240, 22);
            this.tb_trphg_pb.TabIndex = 9;
            // 
            // Phongban
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1212, 450);
            this.Controls.Add(this.tb_trphg_pb);
            this.Controls.Add(this.tb_tenpb_pb);
            this.Controls.Add(this.tb_mapb_pb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_update_pb);
            this.Controls.Add(this.data_phongban);
            this.Name = "Phongban";
            this.Text = "Phongban";
            this.Load += new System.EventHandler(this.Phongban_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_phongban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_phongban;
        private System.Windows.Forms.Button btn_update_pb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_mapb_pb;
        private System.Windows.Forms.TextBox tb_tenpb_pb;
        private System.Windows.Forms.TextBox tb_trphg_pb;
    }
}