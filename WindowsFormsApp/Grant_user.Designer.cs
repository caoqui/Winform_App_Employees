namespace WindowsFormsApp
{
    partial class Grant_user
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_username_grant = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_grant = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_home_grant_user = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_revoke_grant = new System.Windows.Forms.Button();
            this.cbb_bang_grant_user = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // textBox_username_grant
            // 
            this.textBox_username_grant.Location = new System.Drawing.Point(136, 47);
            this.textBox_username_grant.Name = "textBox_username_grant";
            this.textBox_username_grant.Size = new System.Drawing.Size(179, 22);
            this.textBox_username_grant.TabIndex = 1;
            this.textBox_username_grant.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quyền:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bảng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Thuộc tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cho phép ủy quyền:";
            // 
            // checkBox_grant
            // 
            this.checkBox_grant.AutoSize = true;
            this.checkBox_grant.Location = new System.Drawing.Point(138, 239);
            this.checkBox_grant.Name = "checkBox_grant";
            this.checkBox_grant.Size = new System.Drawing.Size(18, 17);
            this.checkBox_grant.TabIndex = 9;
            this.checkBox_grant.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 302);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Grant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_home_grant_user
            // 
            this.btn_home_grant_user.Location = new System.Drawing.Point(556, 23);
            this.btn_home_grant_user.Name = "btn_home_grant_user";
            this.btn_home_grant_user.Size = new System.Drawing.Size(123, 45);
            this.btn_home_grant_user.TabIndex = 11;
            this.btn_home_grant_user.Text = "Home";
            this.btn_home_grant_user.UseVisualStyleBackColor = true;
            this.btn_home_grant_user.Click += new System.EventHandler(this.btn_home_grant_user_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(134, 101);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 24);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(134, 191);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(179, 24);
            this.comboBox2.TabIndex = 13;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // btn_revoke_grant
            // 
            this.btn_revoke_grant.Location = new System.Drawing.Point(309, 302);
            this.btn_revoke_grant.Name = "btn_revoke_grant";
            this.btn_revoke_grant.Size = new System.Drawing.Size(100, 30);
            this.btn_revoke_grant.TabIndex = 14;
            this.btn_revoke_grant.Text = "Revoke";
            this.btn_revoke_grant.UseVisualStyleBackColor = true;
            this.btn_revoke_grant.Click += new System.EventHandler(this.btn_revoke_grant_Click);
            // 
            // cbb_bang_grant_user
            // 
            this.cbb_bang_grant_user.FormattingEnabled = true;
            this.cbb_bang_grant_user.Location = new System.Drawing.Point(133, 143);
            this.cbb_bang_grant_user.Name = "cbb_bang_grant_user";
            this.cbb_bang_grant_user.Size = new System.Drawing.Size(181, 24);
            this.cbb_bang_grant_user.TabIndex = 15;
            this.cbb_bang_grant_user.SelectedIndexChanged += new System.EventHandler(this.cbb_bang_grant_user_SelectedIndexChanged);
            // 
            // Grant_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(807, 450);
            this.Controls.Add(this.cbb_bang_grant_user);
            this.Controls.Add(this.btn_revoke_grant);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_home_grant_user);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBox_grant);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_username_grant);
            this.Controls.Add(this.label1);
            this.Name = "Grant_user";
            this.Text = "Grant_user";
            this.Load += new System.EventHandler(this.Grant_user_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_username_grant;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox_grant;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_home_grant_user;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btn_revoke_grant;
        private System.Windows.Forms.ComboBox cbb_bang_grant_user;
    }
}