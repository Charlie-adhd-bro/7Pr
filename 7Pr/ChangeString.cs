
namespace _7Pr
{
    class ChangeString(string text)
    {
        private string Text = text;

        public string SubStringInsert(int start, string substring)
        {
            string startString = "", endString = "";

            if (start != Text.Length - 1)
            {
                startString = Text.Substring(0, start);
                endString = Text.Substring(start);
            }
            else
            {
                startString = Text;
            }

            Text = startString + substring + endString;

            return ToString();
        }

        public override string ToString() { return Text; }
    }
}
