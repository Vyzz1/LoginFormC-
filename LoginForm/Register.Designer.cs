namespace LoginForm
{
    partial class Register
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            user_id = new TextBox();
            user_pwd = new TextBox();
            label4 = new Label();
            pwd_again = new TextBox();
            label5 = new Label();
            user_name = new TextBox();
            label6 = new Label();
            clear_button = new Button();
            login_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(339, 20);
            label1.Name = "label1";
            label1.Size = new Size(234, 41);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG KÝ USER";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 184);
            label2.Name = "label2";
            label2.Size = new Size(146, 20);
            label2.TabIndex = 1;
            label2.Text = "Tài khoản đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 231);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu";
            // 
            // user_id
            // 
            user_id.Location = new Point(339, 177);
            user_id.Name = "user_id";
            user_id.Size = new Size(312, 27);
            user_id.TabIndex = 3;
            // 
            // user_pwd
            // 
            user_pwd.Location = new Point(339, 228);
            user_pwd.Name = "user_pwd";
            user_pwd.Size = new Size(312, 27);
            user_pwd.TabIndex = 4;
            user_pwd.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(132, 278);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 5;
            label4.Text = "Nhập lại mật khẩu";
            // 
            // pwd_again
            // 
            pwd_again.Location = new Point(339, 278);
            pwd_again.Name = "pwd_again";
            pwd_again.Size = new Size(312, 27);
            pwd_again.TabIndex = 6;
            pwd_again.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(132, 336);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 7;
            // 
            // user_name
            // 
            user_name.Location = new Point(339, 126);
            user_name.Name = "user_name";
            user_name.Size = new Size(312, 27);
            user_name.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(132, 129);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 8;
            label6.Text = "Tên người dùng";
            // 
            // clear_button
            // 
            clear_button.BackColor = Color.Transparent;
            clear_button.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear_button.ForeColor = SystemColors.ActiveCaptionText;
            clear_button.Location = new Point(527, 346);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(119, 40);
            clear_button.TabIndex = 11;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = false;
            clear_button.Click += clear_button_Click;
            // 
            // login_btn
            // 
            login_btn.BackColor = SystemColors.InactiveCaption;
            login_btn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ActiveCaptionText;
            login_btn.Location = new Point(669, 346);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(119, 40);
            login_btn.TabIndex = 10;
            login_btn.Text = "Đăng kí";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 477);
            Controls.Add(clear_button);
            Controls.Add(login_btn);
            Controls.Add(user_name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pwd_again);
            Controls.Add(label4);
            Controls.Add(user_pwd);
            Controls.Add(user_id);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            Load += Register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox user_id;
        private TextBox user_pwd;
        private Label label4;
        private TextBox pwd_again;
        private Label label5;
        private TextBox user_name;
        private Label label6;
        private Button clear_button;
        private Button login_btn;
    }
}