namespace _7Pr
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr7_1 mainForm = new();
            mainForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pr7_2 mainForm = new();
            mainForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pr7_3 mainForm = new();
            mainForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pr7_4 mainForm = new();
            mainForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr7_5 mainForm = new();
            mainForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr7_6 mainForm = new();
            mainForm.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr7_7 mainForm = new();
            mainForm.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr7_8 mainForm = new();
            mainForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            pr7_9 mainForm = new();
            mainForm.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //pr7_10 mainForm = new();
            //mainForm.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
