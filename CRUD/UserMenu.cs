namespace CRUD
{
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            new CreateUser().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            new DeleteUser().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
            new EditUser().Show();
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