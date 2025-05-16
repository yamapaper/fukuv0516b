namespace fukuv0516b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Top -= 20;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Left -= 20;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Left += 20;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Top += 20;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = "ŽR“cŒ’‘¾";
            label1.ForeColor = Color.Red;
        }
    }
}
