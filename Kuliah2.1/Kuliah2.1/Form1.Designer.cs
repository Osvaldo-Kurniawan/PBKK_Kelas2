namespace Kuliah2._1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            Nilai1 = new Label();
            TB_Nilai1 = new TextBox();
            TB_Nilai2 = new TextBox();
            Nilai2 = new Label();
            Hasil = new Label();
            TB_Hasil = new TextBox();
            button5 = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 0, 1);
            tableLayoutPanel1.Controls.Add(button3, 1, 0);
            tableLayoutPanel1.Controls.Add(button4, 1, 1);
            tableLayoutPanel1.Location = new Point(64, 426);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(336, 200);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.DimGray;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(162, 94);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DimGray;
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(3, 103);
            button2.Name = "button2";
            button2.Size = new Size(162, 94);
            button2.TabIndex = 1;
            button2.Text = "x";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DimGray;
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(171, 3);
            button3.Name = "button3";
            button3.Size = new Size(162, 94);
            button3.TabIndex = 2;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DimGray;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(171, 103);
            button4.Name = "button4";
            button4.Size = new Size(162, 94);
            button4.TabIndex = 3;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Nilai1
            // 
            Nilai1.AutoSize = true;
            Nilai1.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Nilai1.ForeColor = SystemColors.ButtonHighlight;
            Nilai1.Location = new Point(64, 82);
            Nilai1.Name = "Nilai1";
            Nilai1.Size = new Size(90, 29);
            Nilai1.TabIndex = 1;
            Nilai1.Text = "Nilai 1 :";
            // 
            // TB_Nilai1
            // 
            TB_Nilai1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_Nilai1.BackColor = Color.Gray;
            TB_Nilai1.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Nilai1.ForeColor = Color.White;
            TB_Nilai1.Location = new Point(165, 79);
            TB_Nilai1.Name = "TB_Nilai1";
            TB_Nilai1.Size = new Size(353, 36);
            TB_Nilai1.TabIndex = 2;
            // 
            // TB_Nilai2
            // 
            TB_Nilai2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            TB_Nilai2.BackColor = Color.Gray;
            TB_Nilai2.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Nilai2.ForeColor = Color.White;
            TB_Nilai2.Location = new Point(165, 162);
            TB_Nilai2.Name = "TB_Nilai2";
            TB_Nilai2.Size = new Size(353, 36);
            TB_Nilai2.TabIndex = 4;
            // 
            // Nilai2
            // 
            Nilai2.AutoSize = true;
            Nilai2.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Nilai2.ForeColor = SystemColors.ButtonHighlight;
            Nilai2.Location = new Point(64, 165);
            Nilai2.Name = "Nilai2";
            Nilai2.Size = new Size(90, 29);
            Nilai2.TabIndex = 3;
            Nilai2.Text = "Nilai 2 :";
            // 
            // Hasil
            // 
            Hasil.AutoSize = true;
            Hasil.Font = new Font("Swis721 BlkCn BT", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Hasil.ForeColor = Color.DarkOrange;
            Hasil.Location = new Point(145, 253);
            Hasil.Name = "Hasil";
            Hasil.Size = new Size(291, 43);
            Hasil.TabIndex = 5;
            Hasil.Text = "Hasil Perhitungan";
            Hasil.TextAlign = ContentAlignment.TopCenter;
            // 
            // TB_Hasil
            // 
            TB_Hasil.Font = new Font("Swis721 BlkCn BT", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TB_Hasil.Location = new Point(64, 328);
            TB_Hasil.Name = "TB_Hasil";
            TB_Hasil.Size = new Size(454, 36);
            TB_Hasil.TabIndex = 6;
            TB_Hasil.TextAlign = HorizontalAlignment.Center;
            // 
            // button5
            // 
            button5.BackColor = Color.DimGray;
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(406, 429);
            button5.Name = "button5";
            button5.Size = new Size(112, 194);
            button5.TabIndex = 7;
            button5.Text = "CE";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(580, 672);
            Controls.Add(button5);
            Controls.Add(TB_Hasil);
            Controls.Add(Hasil);
            Controls.Add(TB_Nilai2);
            Controls.Add(Nilai2);
            Controls.Add(TB_Nilai1);
            Controls.Add(Nilai1);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(602, 728);
            MinimumSize = new Size(602, 728);
            Name = "Form1";
            Text = "Kalkulator WinForm";
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label Nilai1;
        private TextBox TB_Nilai1;
        private TextBox TB_Nilai2;
        private Label Nilai2;
        private Label Hasil;
        private TextBox TB_Hasil;
        private Button button5;
    }
}