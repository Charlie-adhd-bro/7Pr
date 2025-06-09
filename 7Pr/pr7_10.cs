namespace _7Pr
{
    public partial class pr7_10 : Form
    {
        public pr7_10()
        {
            InitializeComponent();
        }


        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (textBoxText.Text.Length == 0
                || !int.TryParse(textBoxText.Text, out int lenght)
                || lenght < 1)
            {
                MessageBox.Show(
                       "Текстовое поле пустое или введенно не " +
                       "число или число меньше 1." +
                       "\nВведите коректное значение",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }


            int[] ints = new int[lenght];

            foreach (int index in Enumerable.Range(0, lenght))
            {
                ints[index] = new Random().Next(-10, 10);
            }

            ArrayAndAvg array = new(ints);

            labelResult.Text = array.ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxText.Clear();

            labelResult.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormMain().Show();
        }

        
    }
}
