namespace Kuliah2._2
{
    partial class Form1
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
            comboBoxWebcamList = new ComboBox();
            buttonStart = new Button();
            buttonCapture = new Button();
            buttonSaveImg = new Button();
            buttonExit = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // comboBoxWebcamList
            // 
            comboBoxWebcamList.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            comboBoxWebcamList.FormattingEnabled = true;
            comboBoxWebcamList.Location = new Point(72, 182);
            comboBoxWebcamList.Name = "comboBoxWebcamList";
            comboBoxWebcamList.Size = new Size(303, 46);
            comboBoxWebcamList.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.BlueViolet;
            buttonStart.Font = new Font("Segoe Fluent Icons", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonStart.ForeColor = Color.White;
            buttonStart.Location = new Point(395, 177);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(106, 51);
            buttonStart.TabIndex = 1;
            buttonStart.Text = "Start";
            buttonStart.TextAlign = ContentAlignment.TopCenter;
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // buttonCapture
            // 
            buttonCapture.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCapture.Location = new Point(889, 664);
            buttonCapture.Name = "buttonCapture";
            buttonCapture.Size = new Size(146, 38);
            buttonCapture.TabIndex = 2;
            buttonCapture.Text = "Capture";
            buttonCapture.UseVisualStyleBackColor = true;
            buttonCapture.Click += buttonCapture_Click;
            // 
            // buttonSaveImg
            // 
            buttonSaveImg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSaveImg.Location = new Point(1041, 664);
            buttonSaveImg.Name = "buttonSaveImg";
            buttonSaveImg.Size = new Size(167, 38);
            buttonSaveImg.TabIndex = 3;
            buttonSaveImg.Text = "Save Image";
            buttonSaveImg.UseVisualStyleBackColor = true;
            buttonSaveImg.Click += buttonSaveImg_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe Fluent Icons", 16F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.DimGray;
            buttonExit.Location = new Point(507, 177);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(101, 51);
            buttonExit.TabIndex = 4;
            buttonExit.Text = "Exit";
            buttonExit.TextAlign = ContentAlignment.TopCenter;
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(72, 314);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(536, 329);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(672, 314);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(536, 329);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.BlueViolet;
            label1.Location = new Point(72, 52);
            label1.Name = "label1";
            label1.Size = new Size(495, 45);
            label1.TabIndex = 5;
            label1.Text = "Welcome To My Webcam App";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.DimGray;
            label2.Location = new Point(72, 128);
            label2.Name = "label2";
            label2.Size = new Size(227, 38);
            label2.TabIndex = 6;
            label2.Text = "Choose camera";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DimGray;
            label3.Location = new Point(72, 263);
            label3.Name = "label3";
            label3.Size = new Size(186, 38);
            label3.TabIndex = 7;
            label3.Text = "Live Camera";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DimGray;
            label4.Location = new Point(672, 263);
            label4.Name = "label4";
            label4.Size = new Size(240, 38);
            label4.TabIndex = 8;
            label4.Text = "Captured Image";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1269, 747);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(buttonExit);
            Controls.Add(buttonSaveImg);
            Controls.Add(buttonCapture);
            Controls.Add(buttonStart);
            Controls.Add(comboBoxWebcamList);
            MaximumSize = new Size(1291, 803);
            MinimumSize = new Size(1291, 803);
            Name = "Form1";
            Text = "Webcam Capture";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxWebcamList;
        private Button buttonStart;
        private Button buttonCapture;
        private Button buttonSaveImg;
        private Button buttonExit;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}