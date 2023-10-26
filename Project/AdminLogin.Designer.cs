namespace Project
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            adminUsername = new TextBox();
            label2 = new Label();
            adminPassword = new TextBox();
            adminLoginButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(140, 17);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(406, 245);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(140, 291);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            // 
            // adminUsername
            // 
            adminUsername.BackColor = SystemColors.ControlDark;
            adminUsername.BorderStyle = BorderStyle.FixedSingle;
            adminUsername.Location = new Point(250, 288);
            adminUsername.MaxLength = 30;
            adminUsername.Name = "adminUsername";
            adminUsername.Size = new Size(216, 29);
            adminUsername.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(140, 336);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(48, 21);
            label2.TabIndex = 3;
            label2.Text = "Şifre:";
            // 
            // adminPassword
            // 
            adminPassword.BackColor = SystemColors.ControlDark;
            adminPassword.BorderStyle = BorderStyle.FixedSingle;
            adminPassword.Location = new Point(250, 333);
            adminPassword.MaxLength = 30;
            adminPassword.Name = "adminPassword";
            adminPassword.Size = new Size(216, 29);
            adminPassword.TabIndex = 4;
            adminPassword.UseSystemPasswordChar = true;
            // 
            // adminLoginButton
            // 
            adminLoginButton.BackColor = Color.Green;
            adminLoginButton.Cursor = Cursors.Hand;
            adminLoginButton.FlatAppearance.BorderColor = Color.Green;
            adminLoginButton.FlatStyle = FlatStyle.Flat;
            adminLoginButton.ForeColor = Color.White;
            adminLoginButton.Location = new Point(265, 383);
            adminLoginButton.Name = "adminLoginButton";
            adminLoginButton.Size = new Size(152, 42);
            adminLoginButton.TabIndex = 5;
            adminLoginButton.Text = "Giriş Yap";
            adminLoginButton.UseVisualStyleBackColor = false;
            adminLoginButton.Click += adminLoginButton_Click;
            // 
            // AdminLogin
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(674, 465);
            Controls.Add(adminLoginButton);
            Controls.Add(adminPassword);
            Controls.Add(label2);
            Controls.Add(adminUsername);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4);
            Name = "AdminLogin";
            Text = "Yönetici Girişi";
            Load += AdminLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox adminUsername;
        private Label label2;
        private TextBox adminPassword;
        private Button adminLoginButton;
    }
}