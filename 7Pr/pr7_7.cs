namespace _7Pr
{
    public partial class pr7_7 : Form
    {
        public pr7_7()
        {
            InitializeComponent();
        }

        static string SubStringEmulation(string text, int start, int count)
        {
            int size = count;

            if (size > text.Length)
            {
                size = text.Length - start;
            }

            char[] subText = new char[size];

            for (int i = 0; i < size; i++)
            {
                if (start < text.Length) 
                { 
                    subText[i] = text[start];
                    start++;
                }
            }


            return new string(subText);
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (textBoxText.Text.Length == 0 ||
                textBoxPosition.Text.Length == 0 ||
                textBoxCount.Text.Length == 0)
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

            if (!int.TryParse(textBoxPosition.Text, out int position) ||
                position >= textBoxText.Text.Length ||
                 position < 0)
            {
                MessageBox.Show(
                       "Ввод не числа или выход за предела массива.\n Введите еще раз",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            if (!int.TryParse(textBoxCount.Text, out int count) || count < 1)
            {
                MessageBox.Show(
                       "Ввод не числа или количество меньше 1.\n Введите еще раз",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            labelResult.Text = "\n1: " + SubStringEmulation(text, position, count);

            //обычный случай
            labelResult.Text += "\n2: " + SubStringEmulation("Привет мир", 7, 3);

            //Количество символов больше длины текста
            labelResult.Text += "\n3: " + SubStringEmulation("Галактика", 5, 100);

            //С начало строки
            labelResult.Text += "\n4: " + SubStringEmulation("hello", 0, 2);

            // минимально возможный
            labelResult.Text += "\n5: " + SubStringEmulation("abcde", 2, 1);


        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxText.Clear();
            textBoxPosition.Clear();
            textBoxCount.Clear();
            labelResult.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }
    }
}
