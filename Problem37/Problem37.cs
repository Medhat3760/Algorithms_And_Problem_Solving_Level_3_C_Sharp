namespace Problem37
{
    // Split String
    internal class Problem37
    {

        static string ReadString(string message)
        {

            string text;

            Console.WriteLine(message);
            text = Console.ReadLine();

            return text;

        }

        static List<string> SplitString(string text, string delimiter)
        {

            List<string> lString = new List<string>();

            string word = "";

            short pos = 0;

            while ((pos = (short)text.IndexOf(delimiter)) != -1)
            {

                word = text.Substring(0, pos);

                if (word != "")
                {
                    lString.Add(word);
                }

                text = text.Substring(pos + delimiter.Length);

            }

            if (text != "")
            {
                lString.Add(text);
            }

            return lString;

        }

        static void Main(string[] args)
        {

            string s1 = ReadString("Please Enter Your String?");

            List<string> lString = SplitString(s1, " ");

            Console.WriteLine("\nTokens = " + lString.Count);

            foreach (string s in lString)
            {
                Console.WriteLine(s);
            }

        }
    }
}