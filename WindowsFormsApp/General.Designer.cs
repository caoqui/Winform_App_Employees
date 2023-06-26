namespace WindowsFormsApp
{
    partial class General
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
            this.button_thongtinnv = new System.Windows.Forms.Button();
            this.button_thongtinpb = new System.Windows.Forms.Button();
            this.button_thongtinda = new System.Windows.Forms.Button();
            this.button_thongtinpc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_thongtinnv
            // 
            this.button_thongtinnv.Location = new System.Drawing.Point(213, 59);
            this.button_thongtinnv.Name = "button_thongtinnv";
            this.button_thongtinnv.Size = new System.Drawing.Size(239, 58);
            this.button_thongtinnv.TabIndex = 0;
            this.button_thongtinnv.Text = "Thông tin nhân viên";
            this.button_thongtinnv.UseVisualStyleBackColor = true;
            this.button_thongtinnv.Click += new System.EventHandler(this.button_thongtinnv_Click);
            // 
            // button_thongtinpb
            // 
            this.button_thongtinpb.Location = new System.Drawing.Point(213, 152);
            this.button_thongtinpb.Name = "button_thongtinpb";
            this.button_thongtinpb.Size = new System.Drawing.Size(237, 51);
            this.button_thongtinpb.TabIndex = 1;
            this.button_thongtinpb.Text = "Thông tin phòng ban";
            this.button_thongtinpb.UseVisualStyleBackColor = true;
            this.button_thongtinpb.Click += new System.EventHandler(this.button_thongtinpb_Click);
            // 
            // button_thongtinda
            // 
            this.button_thongtinda.Location = new System.Drawing.Point(213, 242);
            this.button_thongtinda.Name = "button_thongtinda";
            this.button_thongtinda.Size = new System.Drawing.Size(234, 54);
            this.button_thongtinda.TabIndex = 2;
            this.button_thongtinda.Text = "Thông tin đề án";
            this.button_thongtinda.UseVisualStyleBackColor = true;
            this.button_thongtinda.Click += new System.EventHandler(this.button_thongtinda_Click);
            // 
            // button_thongtinpc
            // 
            this.button_thongtinpc.Location = new System.Drawing.Point(213, 333);
            this.button_thongtinpc.Name = "button_thongtinpc";
            this.button_thongtinpc.Size = new System.Drawing.Size(232, 57);
            this.button_thongtinpc.TabIndex = 3;
            this.button_thongtinpc.Text = "Thông tin phân công";
            this.button_thongtinpc.UseVisualStyleBackColor = true;
            this.button_thongtinpc.Click += new System.EventHandler(this.button_thongtinpc_Click);
            // 
            // General
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_thongtinpc);
            this.Controls.Add(this.button_thongtinda);
            this.Controls.Add(this.button_thongtinpb);
            this.Controls.Add(this.button_thongtinnv);
            this.Name = "General";
            this.Text = "General";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_thongtinnv;
        private System.Windows.Forms.Button button_thongtinpb;
        private System.Windows.Forms.Button button_thongtinda;
        private System.Windows.Forms.Button button_thongtinpc;
    }
}