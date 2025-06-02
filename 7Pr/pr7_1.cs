namespace _7Pr
{
    public partial class pr7_1 : Form
    {
        public pr7_1()
        {
            InitializeComponent();
        }

        static string SpaceBetweenWords(string text)
        {
            string StringArray = "";
            foreach (char symbol in text)
            {
                StringArray += symbol + " ";
            }

            return StringArray;
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {

            if (textBoxInput.Text.Length == 0)
            {
                MessageBox.Show(
                       "Текстовое поле пустое, введите как минимум один символ",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            string text = textBoxInput.Text;
            labelResult.Text = "Результат:\n" + SpaceBetweenWords(text);

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            labelResult.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }
    }
}
