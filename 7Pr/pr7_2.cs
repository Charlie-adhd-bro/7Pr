namespace _7Pr
{
    public partial class Pr7_2 : Form
    {
        public Pr7_2()
        {
            InitializeComponent();
        }

        static string ReverseText(string text)
        {
            string[] words = text.Split(' ');

            Array.Reverse(words);

            return string.Join(" ", words);
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

            labelResult.Text = "Оригинальный текст:\n" + text;
            labelResult.Text += "\nТекст в обратном порядке:\n" + ReverseText(text);
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
