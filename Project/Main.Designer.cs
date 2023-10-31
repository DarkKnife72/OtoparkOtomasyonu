namespace Project
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            mainAdminLabel = new Label();
            panel1 = new Panel();
            mainLabelTotalCars = new Label();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            mainLabelTotalStaff = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            mainLabelTotalPark = new Label();
            label4 = new Label();
            pictureBox4 = new PictureBox();
            mainManagementPanel = new Panel();
            mainLabelTotalCash = new Label();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            mainManagementPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3, toolStripMenuItem4 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(933, 25);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.ForeColor = Color.Black;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(82, 19);
            toolStripMenuItem1.Text = "Araç Kaydet";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.ForeColor = Color.Black;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(73, 19);
            toolStripMenuItem2.Text = "Araç Çıkar";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.ForeColor = Color.Black;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(88, 19);
            toolStripMenuItem3.Text = "Kullanıcı Ekle";
            toolStripMenuItem3.Visible = false;
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(58, 19);
            toolStripMenuItem4.Text = "Kayıtlar";
            toolStripMenuItem4.Visible = false;
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(13, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // mainAdminLabel
            // 
            mainAdminLabel.AutoSize = true;
            mainAdminLabel.Location = new Point(72, 52);
            mainAdminLabel.Name = "mainAdminLabel";
            mainAdminLabel.Size = new Size(54, 21);
            mainAdminLabel.TabIndex = 11;
            mainAdminLabel.Text = "label5";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(mainLabelTotalCars);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(12, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(296, 78);
            panel1.TabIndex = 12;
            // 
            // mainLabelTotalCars
            // 
            mainLabelTotalCars.AutoSize = true;
            mainLabelTotalCars.Location = new Point(3, 18);
            mainLabelTotalCars.Name = "mainLabelTotalCars";
            mainLabelTotalCars.Size = new Size(22, 21);
            mainLabelTotalCars.TabIndex = 2;
            mainLabelTotalCars.Text = "-1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 50);
            label1.Name = "label1";
            label1.Size = new Size(132, 21);
            label1.TabIndex = 1;
            label1.Text = "Garajdaki Araçlar";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(219, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(74, 54);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(mainLabelTotalStaff);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(pictureBox3);
            panel2.Location = new Point(314, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(296, 78);
            panel2.TabIndex = 13;
            // 
            // mainLabelTotalStaff
            // 
            mainLabelTotalStaff.AutoSize = true;
            mainLabelTotalStaff.Location = new Point(3, 18);
            mainLabelTotalStaff.Name = "mainLabelTotalStaff";
            mainLabelTotalStaff.Size = new Size(22, 21);
            mainLabelTotalStaff.TabIndex = 2;
            mainLabelTotalStaff.Text = "-1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 50);
            label3.Name = "label3";
            label3.Size = new Size(161, 21);
            label3.TabIndex = 1;
            label3.Text = "Toplam Çalışan Sayısı";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(219, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(74, 54);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(mainLabelTotalPark);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox4);
            panel3.Location = new Point(616, 109);
            panel3.Name = "panel3";
            panel3.Size = new Size(296, 78);
            panel3.TabIndex = 14;
            // 
            // mainLabelTotalPark
            // 
            mainLabelTotalPark.AutoSize = true;
            mainLabelTotalPark.Location = new Point(3, 18);
            mainLabelTotalPark.Name = "mainLabelTotalPark";
            mainLabelTotalPark.Size = new Size(22, 21);
            mainLabelTotalPark.TabIndex = 2;
            mainLabelTotalPark.Text = "-1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 50);
            label4.Name = "label4";
            label4.Size = new Size(122, 21);
            label4.TabIndex = 1;
            label4.Text = "Boş Park Yerleri";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(219, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(74, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // mainManagementPanel
            // 
            mainManagementPanel.BackColor = Color.FromArgb(64, 64, 64);
            mainManagementPanel.Controls.Add(mainLabelTotalCash);
            mainManagementPanel.Controls.Add(label5);
            mainManagementPanel.Controls.Add(pictureBox5);
            mainManagementPanel.Location = new Point(12, 233);
            mainManagementPanel.Name = "mainManagementPanel";
            mainManagementPanel.Size = new Size(296, 78);
            mainManagementPanel.TabIndex = 15;
            mainManagementPanel.Visible = false;
            // 
            // mainLabelTotalCash
            // 
            mainLabelTotalCash.AutoSize = true;
            mainLabelTotalCash.Location = new Point(3, 18);
            mainLabelTotalCash.Name = "mainLabelTotalCash";
            mainLabelTotalCash.Size = new Size(22, 21);
            mainLabelTotalCash.TabIndex = 2;
            mainLabelTotalCash.Text = "-1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 50);
            label5.Name = "label5";
            label5.Size = new Size(158, 21);
            label5.TabIndex = 1;
            label5.Text = "Kasada Bulunan Para";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(219, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(74, 54);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(933, 562);
            Controls.Add(mainManagementPanel);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(mainAdminLabel);
            Controls.Add(pictureBox1);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.Control;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "Main";
            Text = "Otopark Yönetimi";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            mainManagementPanel.ResumeLayout(false);
            mainManagementPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public static Panel mainManagementPanel;
        public static Label mainLabelTotalCash;
        public static Label label5;
        public static PictureBox pictureBox5;
        public static Panel panel2;
        public static Label mainLabelTotalStaff;
        public static Label label3;
        public static PictureBox pictureBox3;
        public static ToolStripMenuItem toolStripMenuItem4;
        public static MenuStrip menuStrip1;
        public static ToolStripMenuItem toolStripMenuItem1;
        public static ToolStripMenuItem toolStripMenuItem2;
        public static PictureBox pictureBox1;
        public static Label mainAdminLabel;
        public static ToolStripMenuItem toolStripMenuItem3;
        public static Panel panel1;
        public static Label label1;
        public static PictureBox pictureBox2;
        public static Label mainLabelTotalCars;
        public static Panel panel3;
        public static Label mainLabelTotalPark;
        public static Label label4;
        public static PictureBox pictureBox4;
    }
}