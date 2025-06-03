namespace _7Pr
{
    public partial class pr7_6 : Form
    {
        public pr7_6()
        {
            InitializeComponent();
        }

        static char[] MakeCharArray(string text)
        {
            char [] charArray = new char[text.Length];
            int index = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (Char.IsLetter(text[i]))
                {
                    charArray[index] = text[i];
                    index++;
                }
            }

            Array.Resize(ref charArray, index);
            Array.Sort(charArray);

            if (charArray.Length > 0)
            {
                return charArray.Distinct().ToArray();
            }
            else
            {
                return "Массив не содержит букв".ToArray();
            }
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text.Length == 0)
            {
                MessageBox.Show(
                       "Текстовое поле пустое.\n Введите как минимум один символ в поле",
                       "Ошибка ввода", 
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            string text = textBoxInput.Text;

            labelResult.Text = "Символьный массив в алфавитном порядке:\n" + new string(MakeCharArray(text)); 

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
