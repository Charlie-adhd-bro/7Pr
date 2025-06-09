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

            StringAndSymbol stringAndSymbol = new StringAndSymbol(textBoxText.Text, textBoxSymbol.Text[0]);
            labelResult.Text = stringAndSymbol.ToString();

            //разделяющий символ не найден в тексте
            stringAndSymbol = new StringAndSymbol("привет мир", '5');
            labelResult.Text += stringAndSymbol.ToString();

            //один разделяющий символ в тексте
            stringAndSymbol = new StringAndSymbol("привет мир", 'т');
            labelResult.Text += stringAndSymbol.ToString();

            //несколько разделяющих символов в тексте
            stringAndSymbol = new StringAndSymbol("привет мир, ты прекрасен", 'р');
            labelResult.Text += stringAndSymbol.ToString();
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

       
    }
}