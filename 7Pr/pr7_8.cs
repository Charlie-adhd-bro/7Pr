namespace _7Pr
{
    public partial class pr7_8 : Form
    {
        public pr7_8()
        {
            InitializeComponent();
        }


        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (textBoxText.Text.Length == 0
                || textBoxPosition.Text.Length == 0
                || textBoxSubstring.Text.Length == 0)
            {
                MessageBox.Show(
                       "Одно из текстовых полей пустое.\n Введите как минимум один символ во все поля",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            ChangeString changeString = new ChangeString(textBoxText.Text);

            if (!int.TryParse(textBoxPosition.Text, out int position)
                || position >= textBoxText.Text.Length
                || position < 0)
            {
                MessageBox.Show(
                       "Ввод не числа или выход за предела массива.\n Введите еще раз",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            labelResult.Text = changeString.SubStringInsert(position, textBoxSubstring.Text);

            //вставка в начало
            changeString = new ChangeString("1234");
            labelResult.Text += "\nВставка в начало строки \"1234\": " + changeString.SubStringInsert(0, "abcd");

            //вставка в середину
            changeString = new ChangeString("1234");
            labelResult.Text += "\nВставка в середину строки \"1234\": " + changeString.SubStringInsert(2, "abcd");

            //вставка в конец
            changeString = new ChangeString("1234");
            labelResult.Text += "\nВставка в конец строки \"1234\": " + changeString.SubStringInsert(3, "abcd");

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxText.Clear();
            textBoxPosition.Clear();
            textBoxSubstring.Clear();
            labelResult.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }

        class ChangeString(string text)
        {
            private string Text = text;

            public string SubStringInsert(int start, string substring)
            {
                string startString, endString = "";

                if (start != Text.Length-1)
                {
                    startString = Text.Substring(0, start);
                    endString = Text.Substring(start);
                }
                else
                {
                    startString = Text;
                }

                Text = startString + substring + endString;

                return ToString();
            }

            public override string ToString() { return Text; }
        }
    }
}
