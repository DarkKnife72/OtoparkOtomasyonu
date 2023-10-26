namespace Project
{
    partial class VehicleSave
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
            label4 = new Label();
            saveBrand = new TextBox();
            saveModel = new TextBox();
            savePlate = new TextBox();
            saveOwner = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            saveAdminLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 51);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 0;
            label1.Text = "Araç Markası:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(103, 21);
            label2.TabIndex = 1;
            label2.Text = "Araç Modeli:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 138);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 21);
            label3.TabIndex = 2;
            label3.Text = "Araç Plakası:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 180);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 21);
            label4.TabIndex = 3;
            label4.Text = "Araç Sahibi:";
            // 
            // saveBrand
            // 
            saveBrand.BackColor = SystemColors.ControlDark;
            saveBrand.BorderStyle = BorderStyle.FixedSingle;
            saveBrand.Location = new Point(127, 51);
            saveBrand.MaxLength = 30;
            saveBrand.Name = "saveBrand";
            saveBrand.Size = new Size(201, 29);
            saveBrand.TabIndex = 4;
            // 
            // saveModel
            // 
            saveModel.BackColor = SystemColors.ControlDark;
            saveModel.BorderStyle = BorderStyle.FixedSingle;
            saveModel.Location = new Point(127, 94);
            saveModel.MaxLength = 30;
            saveModel.Name = "saveModel";
            saveModel.Size = new Size(201, 29);
            saveModel.TabIndex = 5;
            // 
            // savePlate
            // 
            savePlate.BackColor = SystemColors.ControlDark;
            savePlate.BorderStyle = BorderStyle.FixedSingle;
            savePlate.Location = new Point(127, 136);
            savePlate.MaxLength = 30;
            savePlate.Name = "savePlate";
            savePlate.Size = new Size(201, 29);
            savePlate.TabIndex = 6;
            // 
            // saveOwner
            // 
            saveOwner.BackColor = SystemColors.ControlDark;
            saveOwner.BorderStyle = BorderStyle.FixedSingle;
            saveOwner.Location = new Point(127, 178);
            saveOwner.MaxLength = 30;
            saveOwner.Name = "saveOwner";
            saveOwner.Size = new Size(201, 29);
            saveOwner.TabIndex = 7;
            // 
            // button1
            // 
            button1.BackColor = Color.Green;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 229);
            button1.Name = "button1";
            button1.Size = new Size(172, 47);
            button1.TabIndex = 8;
            button1.Text = "Araç Girişini Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(53, 42);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // saveAdminLabel
            // 
            saveAdminLabel.AutoSize = true;
            saveAdminLabel.Location = new Point(65, 18);
            saveAdminLabel.Name = "saveAdminLabel";
            saveAdminLabel.Size = new Size(54, 21);
            saveAdminLabel.TabIndex = 10;
            saveAdminLabel.Text = "label5";
            // 
            // VehicleSave
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(574, 288);
            Controls.Add(saveAdminLabel);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(saveOwner);
            Controls.Add(savePlate);
            Controls.Add(saveModel);
            Controls.Add(saveBrand);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.Control;
            Margin = new Padding(4);
            Name = "VehicleSave";
            Text = "Araç Kaydı";
            Load += VehicleSave_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox saveBrand;
        private TextBox saveModel;
        private TextBox savePlate;
        private TextBox saveOwner;
        private Button button1;
        private PictureBox pictureBox1;
        private Label saveAdminLabel;
    }
}