namespace Project
{
    partial class UserAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserAdd));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            useraddUsername = new TextBox();
            userAddLevel = new TextBox();
            useraddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(96, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(367, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 252);
            label1.Name = "label1";
            label1.Size = new Size(103, 21);
            label1.TabIndex = 1;
            label1.Text = "Kullanıcı Adı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(96, 296);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 2;
            label2.Text = "Yönetici Seviyesi:";
            // 
            // useraddUsername
            // 
            useraddUsername.BackColor = Color.Black;
            useraddUsername.BorderStyle = BorderStyle.FixedSingle;
            useraddUsername.ForeColor = Color.White;
            useraddUsername.Location = new Point(205, 250);
            useraddUsername.MaxLength = 30;
            useraddUsername.Name = "useraddUsername";
            useraddUsername.Size = new Size(209, 29);
            useraddUsername.TabIndex = 3;
            // 
            // userAddLevel
            // 
            userAddLevel.BackColor = Color.Black;
            userAddLevel.BorderStyle = BorderStyle.FixedSingle;
            userAddLevel.ForeColor = Color.White;
            userAddLevel.Location = new Point(236, 294);
            userAddLevel.MaxLength = 1;
            userAddLevel.Name = "userAddLevel";
            userAddLevel.Size = new Size(178, 29);
            userAddLevel.TabIndex = 4;
            // 
            // useraddButton
            // 
            useraddButton.BackColor = Color.Green;
            useraddButton.FlatStyle = FlatStyle.Popup;
            useraddButton.ForeColor = Color.White;
            useraddButton.Location = new Point(161, 341);
            useraddButton.Name = "useraddButton";
            useraddButton.Size = new Size(196, 51);
            useraddButton.TabIndex = 5;
            useraddButton.Text = "Kullanıcı Ekle";
            useraddButton.UseVisualStyleBackColor = false;
            useraddButton.Click += useraddButton_Click;
            // 
            // UserAdd
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(545, 420);
            Controls.Add(useraddButton);
            Controls.Add(userAddLevel);
            Controls.Add(useraddUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4);
            Name = "UserAdd";
            Text = "Kullanıcı Ekleme";
            Load += UserAdd_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox useraddUsername;
        private TextBox userAddLevel;
        private Button useraddButton;
    }
}