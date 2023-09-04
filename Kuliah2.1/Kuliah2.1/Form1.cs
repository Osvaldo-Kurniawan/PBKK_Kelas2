namespace Kuliah2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Check if TB_Nilai1 and TB_Nilai2 are empty or null
            if (string.IsNullOrEmpty(TB_Nilai1.Text) || string.IsNullOrEmpty(TB_Nilai2.Text))
            {
                MessageBox.Show("Please enter values in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(TB_Nilai1.Text, out int nilai1) && int.TryParse(TB_Nilai2.Text, out int nilai2))
            {
                int hasil = nilai1 + nilai2;
                TB_Hasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Check if TB_Nilai1 and TB_Nilai2 are empty or null
            if (string.IsNullOrEmpty(TB_Nilai1.Text) || string.IsNullOrEmpty(TB_Nilai2.Text))
            {
                MessageBox.Show("Please enter values in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(TB_Nilai1.Text, out int nilai1) && int.TryParse(TB_Nilai2.Text, out int nilai2))
            {
                int hasil = nilai1 - nilai2;
                TB_Hasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if TB_Nilai1 and TB_Nilai2 are empty or null
            if (string.IsNullOrEmpty(TB_Nilai1.Text) || string.IsNullOrEmpty(TB_Nilai2.Text))
            {
                MessageBox.Show("Please enter values in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(TB_Nilai1.Text, out int nilai1) && int.TryParse(TB_Nilai2.Text, out int nilai2))
            {
                int hasil = nilai1 * nilai2;
                TB_Hasil.Text = hasil.ToString();
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Check if TB_Nilai1 and TB_Nilai2 are empty or null
            if (string.IsNullOrEmpty(TB_Nilai1.Text) || string.IsNullOrEmpty(TB_Nilai2.Text))
            {
                MessageBox.Show("Please enter values in both fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(TB_Nilai1.Text, out int nilai1) && int.TryParse(TB_Nilai2.Text, out int nilai2))
            {
                if (nilai2 == 0)
                {
                    MessageBox.Show("Denominator cannot be zero. Please enter a non-zero value for the second number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int hasil = nilai1 / nilai2;
                    TB_Hasil.Text = hasil.ToString();
                }
            }
            else
            {
                MessageBox.Show("Invalid input. Please enter valid integers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TB_Hasil.Text = "";
            TB_Nilai1.Text = "";
            TB_Nilai2.Text = "";
        }
    }
}