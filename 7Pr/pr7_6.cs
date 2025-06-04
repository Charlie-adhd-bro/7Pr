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
            charArray = charArray.Distinct().ToArray();

            MessageBox.Show(
                       $"{new string(charArray)} Длина массива {charArray.Length}",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );

            Array.Sort(charArray);
            MessageBox.Show(
                      $"Отсортированный массив {new string(charArray)}",
                      "Ошибка ввода",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Error
                  );

            if (charArray.Length > 0)
            {
                return charArray;
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

            labelResult.Text = "Символьный массив в алфавитном порядке:\n" 
                + new string(MakeCharArray(text));

            //с не буквенными символами
            labelResult.Text += "\nСимвольный массив в алфавитном порядке:\n" 
                + new string(MakeCharArray("Привет, мир6!"));

            //алфавитный порядок только буквенные символы
            labelResult.Text += "\nСимвольный массив в алфавитном порядке:\n"
                + new string(MakeCharArray("abcdefg"));

            //только буквенные символы в разнобой с несколькими одинаковыми символами
            labelResult.Text += "\nСимвольный массив в алфавитном порядке:\n" 
                + new string(MakeCharArray("aaaccbcccdefg"));

            //без букв
            labelResult.Text += "\nСимвольный массив в алфавитном порядке:\n" 
                + new string(MakeCharArray("!@#$%"));

            //не алфавитный порядок только буквенные символы
            labelResult.Text += "\nСимвольный массив в алфавитном порядке:\n" 
                + new string(MakeCharArray("gfedcba"));
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
