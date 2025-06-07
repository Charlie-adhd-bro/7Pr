using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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
            if (textBoxText.Text.Length == 0 || textBoxSymbol.Text.Length == 0)
            {
                MessageBox.Show(
                       "Одно из текстовых полей пустое.\nВведите как минимум один символ во все поля",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            if (textBoxSymbol.Text.Length > 1)
            {
                MessageBox.Show(
                       "Введено больше одного символа.\nВведите один символ в поле для символа",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            var stringAndSymbol = new StringAndSymbol(textBoxText.Text, textBoxSymbol.Text[0]);
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

        // Вложенный класс
        class StringAndSymbol
        {
            private char Symbol;
            private string Text;

            public StringAndSymbol(string text, char symbol)
            {
                Text = text;
                Symbol = symbol;
            }

            public string[] SubStringDivide()
            {            
                List<string> parts = new List<string>();
                int startIndex = 0;

                for (int i = 0; i < Text.Length; i++)
                {
                    if (Text[i] == Symbol)
                    { 
                        parts.Add(Text.Substring(startIndex, i - startIndex + 1));
                        startIndex = i + 1;
                    }
                }
                
                if (startIndex < Text.Length)
                {
                    parts.Add(Text.Substring(startIndex));
                }

                return parts.ToArray();
            }

            public override string ToString()
            {
                return $"Текст: {Text}\nСимвол: {Symbol}\n" +
                    $"Подстроки: {string.Join(", ", SubStringDivide())}";
            }
        }
    }
}