namespace _7Pr
{
    public partial class Pr7_4 : Form
    {
        public Pr7_4()
        {
            InitializeComponent();
        }

        static bool compareStrings(string text1, string text2)
        {
            char[] firstText = text1.ToArray().Distinct().ToArray();
            char[] secondText = text2.ToArray().Distinct().ToArray();

            return new string(firstText) == new string(secondText);

        }

        private void buttonResult_Click(object sender, EventArgs e)
        {

            if (textBoxFirst.Text.Length == 0 || textBoxSecond.Text.Length == 0)
            {
                MessageBox.Show(
                       "Одно из текстовых полей пустое.\n Введите как минимум один символ в каждое поле",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }


            string text1 = textBoxFirst.Text;
            string text2 = textBoxSecond.Text;


            labelResult.Text = "Они " + text1 + ", " + text2 + " " + compareStrings(text1, text2);

            //различаются
            labelResult.Text += "\nОни " + " (hello, world) " + compareStrings("hello", "world");

            //один набор букв разное количество
            labelResult.Text += "\nОни " + " (аааавг, авг) " + compareStrings("аааавг", "авг");

            //один набор букв одинаковое количество разнобой
            labelResult.Text += "\nОни " + " (test, sett) " + compareStrings("test", "sett");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxFirst.Clear();
            textBoxSecond.Clear();
            labelResult.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }
    }
}
