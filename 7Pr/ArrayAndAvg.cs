namespace _7Pr
{
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
