namespace Problem41
{
    // Reverse Words
    internal class Problem41
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

        static string ReverseWordsInString(string text)
        {

            string reversedWords = "";

            List<string> lWords = SplitString(text, " ");

            for (int i = lWords.Count - 1; i >= 0; i--)
            {
                reversedWords += lWords[i] + " ";
            }

            reversedWords = reversedWords.Substring(0, reversedWords.Length - 1);

            return reversedWords;

        }

        static void Main(string[] args)
        {

            string s1 = ReadString("Please Enter Your String?");

            Console.WriteLine("\nString after reversing words:\n" + ReverseWordsInString(s1));

        }
    }
}