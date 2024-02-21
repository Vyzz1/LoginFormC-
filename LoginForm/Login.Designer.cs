namespace LoginForm
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            id_Input = new TextBox();
            pwd_Input = new TextBox();
            login_btn = new Button();
            clear_button = new Button();
            label4 = new Label();
            Register_Link = new LinkLabel();
            btn_rmb = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(360, 44);
            label1.Name = "label1";
            label1.Size = new Size(262, 45);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(153, 153);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 1;
            label2.Text = "ID ĐĂNG NHẬP";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(153, 209);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 2;
            label3.Text = "MẬT KHẨU";
            // 
            // id_Input
            // 
            id_Input.Location = new Point(320, 146);
            id_Input.Name = "id_Input";
            id_Input.Size = new Size(333, 27);
            id_Input.TabIndex = 3;
            // 
            // pwd_Input
            // 
            pwd_Input.Location = new Point(320, 202);
            pwd_Input.Name = "pwd_Input";
            pwd_Input.Size = new Size(333, 27);
            pwd_Input.TabIndex = 4;
            pwd_Input.UseSystemPasswordChar = true;
            // 
            // login_btn
            // 
            login_btn.BackColor = SystemColors.HotTrack;
            login_btn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ActiveCaptionText;
            login_btn.Location = new Point(676, 254);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(119, 40);
            login_btn.TabIndex = 5;
            login_btn.Text = "Đăng nhập";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // clear_button
            // 
            clear_button.BackColor = SystemColors.ControlDark;
            clear_button.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            clear_button.ForeColor = SystemColors.ActiveCaptionText;
            clear_button.Location = new Point(534, 254);
            clear_button.Name = "clear_button";
            clear_button.Size = new Size(119, 40);
            clear_button.TabIndex = 6;
            clear_button.Text = "Clear";
            clear_button.UseVisualStyleBackColor = false;
            clear_button.Click += clear_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(497, 341);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 7;
            label4.Text = "New User ?";
            // 
            // Register_Link
            // 
            Register_Link.AutoSize = true;
            Register_Link.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Register_Link.LinkColor = Color.LightCoral;
            Register_Link.Location = new Point(586, 344);
            Register_Link.Name = "Register_Link";
            Register_Link.Size = new Size(61, 17);
            Register_Link.TabIndex = 8;
            Register_Link.TabStop = true;
            Register_Link.Text = "Register ";
            Register_Link.LinkClicked += Register_Link_LinkClicked;
            // 
            // btn_rmb
            // 
            btn_rmb.AutoSize = true;
            btn_rmb.Location = new Point(320, 263);
            btn_rmb.Name = "btn_rmb";
            btn_rmb.Size = new Size(129, 24);
            btn_rmb.TabIndex = 9;
            btn_rmb.Text = "Remember me";
            btn_rmb.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(916, 428);
            Controls.Add(btn_rmb);
            Controls.Add(Register_Link);
            Controls.Add(label4);
            Controls.Add(clear_button);
            Controls.Add(login_btn);
            Controls.Add(pwd_Input);
            Controls.Add(id_Input);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FormLogin";
            Text = "FormLogin";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox id_Input;
        private TextBox pwd_Input;
        private Button login_btn;
        private Button clear_button;
        private Label label4;
        private LinkLabel Register_Link;
        private CheckBox btn_rmb;
    }
}
