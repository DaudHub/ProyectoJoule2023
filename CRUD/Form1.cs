namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new Form2().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new Form3().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new Form4().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}