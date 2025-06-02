namespace _7Pr
{
    public partial class Pr7_3 : Form
    {
        public Pr7_3()
        {
            InitializeComponent();
        }

        static string compareStrings(string text1, string text2)
        {
            char[] firstText = text1.ToCharArray();
            char[] secondText = text2.ToCharArray();

            if (firstText.Length != secondText.Length) return "не совпадают";

            int compareness = 0;

            for (int i = 0; i < firstText.Length; i++)
            {
                int check = (int)firstText[i] - (int)secondText[i];
                //MessageBox.Show(check.ToString());

                if (check == 1 || check == -1 
                    || check == 0)
                {
                    compareness++;
                }
            }

            if (compareness == secondText.Length)
            {
                return "совпадают";
            }
            else
            {
                return "не совпадают";
            }

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

            labelResult.Text = "Они " + text1 + ", " +text2 + " " + compareStrings(text1, text2);

            //Различие на 1 совпадение
            labelResult.Text += "\nОни " +  " (hello, hfmmp) " + compareStrings("hello", "hfmmp");

            //Полное совпадение
            labelResult.Text += "\nОни " + " (abc, abc) " + compareStrings("abc", "abc");

            //Различие на 1
            labelResult.Text += "\nОни " + " (a, b) " + compareStrings("a", "b");

            // Разные длины
            labelResult.Text += "\nОни " + " (abc, ab) " + compareStrings("abc", "ab");


            //Различие на 2
            labelResult.Text += "\nОни " + " (hello, hfnmp) " + compareStrings("hello", "hfnmp");

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
