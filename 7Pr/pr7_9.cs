using Microsoft.VisualBasic;
using System.Linq;

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

            if( textBoxSymbol.Text.Length > 1)
            {
                MessageBox.Show(
                       "Введено больше одного символа.\n Введите один символ в поле для символа",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            StringAndSymbol stringAndSymbol = new StringAndSymbol(textBoxText.Text, textBoxSymbol.Text[0]);

            labelResult.Text = stringAndSymbol.ToString();

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

            public string[] SubStringDivide()
            {
                int count = Text.Count(c => c == Symbol);
                string[] strings = new string[count];
                if (count > 0)
                {
                    return strings = Text.Split(Symbol, StringSplitOptions.RemoveEmptyEntries);
                   
                }
                else
                {
                    return [$"Символ разделитель \"{Symbol}\" не найден в этом тексте"];
                }
            }

            public override string ToString()
            {
                return $"\nТекст: {Text},\nСимвол: {Symbol},\nПодстроки: {String.Join(", ", SubStringDivide())}";
            }
        }
    }
}
