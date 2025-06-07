using Microsoft.VisualBasic;

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
            labelResult.Text = stringAndSymbol.SubStringDivide().ToString();

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
                    count--;
                    for (int i = Text.Length - 1; i >= 0; i--)
                    {
                        if (Symbol == Text[i])
                        {
                            strings[count] = Text.Substring(i);
                            count--;
                            Text = Text.Substring(0, i);
                        }
                    }
                }
                else
                {
                    strings[1] = $"Символ разделитель \"{Symbol}\" не найден в этом тексте";
                }
                return ToString(strings);
            }

            public override string ToString(string[] strings) 
            {
                if (strings[1] == $"Символ разделитель \"{Symbol}\" не найден в этом тексте")
                {
                    return Text = strings[1];
                }
                Text = String.Join(", ", strings);
                return Text; 
            }
        }
    }
}
/*Конечно! В стандартном методе `Split()` разделитель удаляется из результата. Чтобы оставить разделитель в полученных подстроках, нужно использовать другой подход.

Вот один из способов — использовать регулярные выражения или вручную разбивать строку, сохраняя разделитель.

### Решение с использованием `Regex.Split()` и захватывающих групп

Можно использовать `Regex.Split()` с группами, чтобы оставить разделитель в результате.

Пример:

```csharp
using System.Text.RegularExpressions;

// В методе GetSubStrings() заменить на:

public string[] GetSubStrings()
{
    // Создаем шаблон для поиска разделителя и его сохранения
    string pattern = $"(\\{Symbol})"; // Экранирование, если Symbol — спецсимвол regex

    // Если Symbol — спецсимвол regex, его нужно экранировать
    if ("^$.*+?()[]{}|\"\\"
        .Contains(Symbol))
    {
        pattern = $"(\\{Regex.Escape(Symbol.ToString())})";
    }

    var parts = Regex.Split(Text, pattern);
    return parts;
}
```

### Объяснение:
- Используем `Regex.Split()` с группой `(\\{Symbol})`, чтобы разделить строку по символу и оставить его в результате.
- В результате получим массив, где разделитель будет включен как отдельный элемент.

### Полный пример метода:

```csharp
public string[] GetSubStrings()
{
    string pattern = $"({Regex.Escape(Symbol.ToString())})";
    var parts = Regex.Split(Text, pattern);
    return parts;
}
```

### Что это даст:
- Строка разбивается по символу, но сам символ остается в массиве как отдельный элемент.
- Можно далее обрабатывать массив по необходимости.

---

Если нужно — я могу помочь интегрировать это в ваш класс полностью.*/