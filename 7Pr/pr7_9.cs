namespace _7Pr
{
    public partial class pr7_9 : Form
    {
        public pr7_9()
        {
            InitializeComponent();
        }


        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (textBoxText.Text.Length == 0
                || textBoxSymbol.Text.Length == 0)
            {
                MessageBox.Show(
                       "Одно из текстовых полей пустое.\n Введите как минимум один символ во все поля",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            StringAndSymbol stringAndSymbol = new StringAndSymbol(textBoxText.Text, textBoxSymbol.Text[0]);
            labelResult.Text = stringAndSymbol.SubStringDivide();

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxText.Clear();

            textBoxSymbol.Clear();
            labelResult.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }

        class StringAndSymbol(string text, char symbol)
        {
            private char Symbol = symbol;
            private string Text = text;

            public string SubStringDivide()
            {
                int count = Text.Count(c => c == Symbol);
                string[] strings = new string[count];

                count--;
                for (int i = Text.Length-1; i>= 0; i--)
                {
                    if (Symbol == Text[i])
                    {
                        strings[count] = Text.Substring(i);
                        count--;
                    }
                }
                Text = String.Join (", ", strings);
                return ToString();
            }

            public override string ToString() { return Text; }
        }
    }
}
