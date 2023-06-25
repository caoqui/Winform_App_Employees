namespace WindowsFormsApp
{
    partial class Users
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
            this.dataAccount = new System.Windows.Forms.DataGridView();
            this.btn_add_user = new System.Windows.Forms.Button();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.txb_user_role = new System.Windows.Forms.Label();
            this.txb_change_pw = new System.Windows.Forms.Label();
            this.btn_delete_user = new System.Windows.Forms.Button();
            this.btn_change_pw = new System.Windows.Forms.Button();
            this.btn_view_user = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_view_privileges = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // dataAccount
            // 
            this.dataAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAccount.Location = new System.Drawing.Point(16, 32);
            this.dataAccount.Name = "dataAccount";
            this.dataAccount.RowHeadersWidth = 51;
            this.dataAccount.RowTemplate.Height = 24;
            this.dataAccount.Size = new System.Drawing.Size(432, 406);
            this.dataAccount.TabIndex = 0;
            // 
            // btn_add_user
            // 
            this.btn_add_user.Location = new System.Drawing.Point(641, 143);
            this.btn_add_user.Name = "btn_add_user";
            this.btn_add_user.Size = new System.Drawing.Size(107, 47);
            this.btn_add_user.TabIndex = 1;
            this.btn_add_user.Text = "Add user";
            this.btn_add_user.UseVisualStyleBackColor = true;
            this.btn_add_user.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(660, 32);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(242, 22);
            this.textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(660, 86);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(242, 22);
            this.textBox_password.TabIndex = 3;
            // 
            // txb_user_role
            // 
            this.txb_user_role.AutoSize = true;
            this.txb_user_role.Location = new System.Drawing.Point(529, 38);
            this.txb_user_role.Name = "txb_user_role";
            this.txb_user_role.Size = new System.Drawing.Size(73, 16);
            this.txb_user_role.TabIndex = 4;
            this.txb_user_role.Text = "Username:";
            // 
            // txb_change_pw
            // 
            this.txb_change_pw.AutoSize = true;
            this.txb_change_pw.Location = new System.Drawing.Point(529, 86);
            this.txb_change_pw.Name = "txb_change_pw";
            this.txb_change_pw.Size = new System.Drawing.Size(119, 16);
            this.txb_change_pw.TabIndex = 5;
            this.txb_change_pw.Text = "Change password:";
            // 
            // btn_delete_user
            // 
            this.btn_delete_user.Location = new System.Drawing.Point(776, 141);
            this.btn_delete_user.Name = "btn_delete_user";
            this.btn_delete_user.Size = new System.Drawing.Size(115, 50);
            this.btn_delete_user.TabIndex = 6;
            this.btn_delete_user.Text = "Delete";
            this.btn_delete_user.UseVisualStyleBackColor = true;
            this.btn_delete_user.Click += new System.EventHandler(this.btn_delete_user_Click);
            // 
            // btn_change_pw
            // 
            this.btn_change_pw.Location = new System.Drawing.Point(920, 138);
            this.btn_change_pw.Name = "btn_change_pw";
            this.btn_change_pw.Size = new System.Drawing.Size(126, 50);
            this.btn_change_pw.TabIndex = 7;
            this.btn_change_pw.Text = "Change password";
            this.btn_change_pw.UseVisualStyleBackColor = true;
            this.btn_change_pw.Click += new System.EventHandler(this.btn_change_pw_Click);
            // 
            // btn_view_user
            // 
            this.btn_view_user.Location = new System.Drawing.Point(502, 143);
            this.btn_view_user.Name = "btn_view_user";
            this.btn_view_user.Size = new System.Drawing.Size(107, 45);
            this.btn_view_user.TabIndex = 9;
            this.btn_view_user.Text = "View";
            this.btn_view_user.UseVisualStyleBackColor = true;
            this.btn_view_user.Click += new System.EventHandler(this.btn_view_user_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(77, 466);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Grant / Revoke user";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_view_privileges
            // 
            this.btn_view_privileges.Location = new System.Drawing.Point(294, 466);
            this.btn_view_privileges.Name = "btn_view_privileges";
            this.btn_view_privileges.Size = new System.Drawing.Size(154, 44);
            this.btn_view_privileges.TabIndex = 11;
            this.btn_view_privileges.Text = "View privileges";
            this.btn_view_privileges.UseVisualStyleBackColor = true;
            this.btn_view_privileges.Click += new System.EventHandler(this.btn_view_privileges_Click);
            // 
            // Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 541);
            this.Controls.Add(this.btn_view_privileges);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_view_user);
            this.Controls.Add(this.btn_change_pw);
            this.Controls.Add(this.btn_delete_user);
            this.Controls.Add(this.txb_change_pw);
            this.Controls.Add(this.txb_user_role);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.btn_add_user);
            this.Controls.Add(this.dataAccount);
            this.Name = "Users";
            this.Text = "Users";
            this.Load += new System.EventHandler(this.Users_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataAccount;
        private System.Windows.Forms.Button btn_add_user;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label txb_user_role;
        private System.Windows.Forms.Label txb_change_pw;
        private System.Windows.Forms.Button btn_delete_user;
        private System.Windows.Forms.Button btn_change_pw;
        private System.Windows.Forms.Button btn_view_user;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_view_privileges;
    }
}