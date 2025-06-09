namespace _7Pr
{
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
            if (startIndex == 0)
            {
                parts = [];
                parts.Add("В тексте не найден символ разделитель");

            }
            return parts.ToArray();
        }

        public override string ToString()
        {
            return $"Текст: {Text}\nСимвол: {Symbol}\n" +
                $"Подстроки: {string.Join(", ", SubStringDivide())}\n\n";
        }
    }
}
