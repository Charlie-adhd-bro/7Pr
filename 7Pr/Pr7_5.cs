namespace _7Pr
{
    public partial class pr7_5 : Form
    {
        public pr7_5()
        {
            InitializeComponent();
        }

        static int[] FindPositionsInArray(string text, char symbol)
        {
            int[] positions = new int[text.Length];
            int index = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == symbol)
                {
                    positions[index] = i;
                    index++;
                }
            }

            Array.Resize(ref positions, index);

            if (positions.Length > 0)
            {
                return positions;
            }
            else
            {
                Array.Resize(ref positions, 1);
                positions[0] = -1;
                return positions;
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (textBoxText.Text.Length == 0 || textBoxSymbol.Text.Length == 0)
            {
                MessageBox.Show(
                       "Одно из текстовых полей пустое.\n Введите как минимум один символ во все поля",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            string text = textBoxText.Text;
            char symbol = textBoxSymbol.Text[0];

            labelResult.Text = "Символьный массив в алфавитном порядке:\n" + String.Join(", ", FindPositionsInArray(text, symbol));

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxText.Clear();
            labelResult.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }

        private void textBoxSymbol_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
