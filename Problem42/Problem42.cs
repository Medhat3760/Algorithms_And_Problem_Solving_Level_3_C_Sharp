namespace Problem42
{
    // Replace Words
    internal class Problem42
    {

        static List<string> SplitString(string text, string delim)
        {

            List<string> lWords = new List<string>();

            string sWord = "";
            short pos = 0;

            while ((pos = (short)text.IndexOf(delim)) != -1)
            {

                sWord = text.Substring(0, pos);

                if (sWord != "")
                {
                    lWords.Add(sWord);
                }
                text = text.Substring(pos + delim.Length);

            }

            if (text != "")
            {
                lWords.Add(text);
            }

            return lWords;
        }

        static string ReplaceWord(string text, string word, string replaceTo)
        {

            string text2 = "";

            List<string> lWords = SplitString(text, " ");

            for (short i = 0; i < lWords.Count; i++)
            {

                if (lWords[i] == word)
                {

                    lWords[i] = replaceTo;

                }

                text2 += lWords[i] + " ";

            }

            text2 = text2.Substring(0, text2.Length - 1);

            return text2;

        }

        static void Main(string[] args)
        {

            string s1 = "Welcome to Egypt , Egypt is a nice country";

            Console.WriteLine("\nOriginal String:\n" + s1);

            Console.WriteLine("\nString After Replace: ");

            Console.WriteLine(ReplaceWord(s1, "Egypt", "USA"));

        }
    }
}