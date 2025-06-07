using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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

            ArrayAndAvg array = new ArrayAndAvg(ints);

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

        class ArrayAndAvg
        {
            private static int[] Array;
            public ArrayAndAvg(int[] array) //конструктор
            {
                Array = array;
            }

            public static float FindAvg()
            {
                if (Array == null || Array.Length == 0)
                {
                    return 0;
                }
                float avg = 0;

                foreach (int num in Array)
                {
                    avg += num;
                }

                avg = ((float)Math.Round(avg / Array.Length, 2));
                return avg;
            }

            public override string ToString()
            {
                return $"Массив из случайных чисел: {string.Join(", ", Array)}, " +
                    $"\nСреднее значение: {FindAvg()}";
            }
        }
    }
}
