namespace WindowsFormsApp
{
    partial class PrivilegesTK
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
            this.privileges_data = new System.Windows.Forms.DataGridView();
            this.btn_home_privileges_tk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.privileges_data)).BeginInit();
            this.SuspendLayout();
            // 
            // privileges_data
            // 
            this.privileges_data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.privileges_data.Location = new System.Drawing.Point(238, 12);
            this.privileges_data.Name = "privileges_data";
            this.privileges_data.RowHeadersWidth = 51;
            this.privileges_data.RowTemplate.Height = 24;
            this.privileges_data.Size = new System.Drawing.Size(550, 426);
            this.privileges_data.TabIndex = 0;
            this.privileges_data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.privileges_data_CellContentClick);
            // 
            // btn_home_privileges_tk
            // 
            this.btn_home_privileges_tk.Location = new System.Drawing.Point(12, 12);
            this.btn_home_privileges_tk.Name = "btn_home_privileges_tk";
            this.btn_home_privileges_tk.Size = new System.Drawing.Size(167, 50);
            this.btn_home_privileges_tk.TabIndex = 1;
            this.btn_home_privileges_tk.Text = "Home";
            this.btn_home_privileges_tk.UseVisualStyleBackColor = true;
            this.btn_home_privileges_tk.Click += new System.EventHandler(this.btn_home_privileges_tk_Click);
            // 
            // PrivilegesTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_home_privileges_tk);
            this.Controls.Add(this.privileges_data);
            this.Name = "PrivilegesTK";
            this.Text = "PrivilegesTK";
            ((System.ComponentModel.ISupportInitialize)(this.privileges_data)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView privileges_data;
        private System.Windows.Forms.Button btn_home_privileges_tk;
    }
}