namespace Problem42_version2
{
    // Replace Words
    internal class Problem42_version2
    {

        static string ReplaceWordInStringUsingBuiltInFunction(string text, string word, string replaceTo)
        {

            short pos = (short)text.IndexOf(word);

            while (pos != -1)
            {

                text = text.Remove(pos, word.Length).Insert(pos, replaceTo);

                pos = (short)text.IndexOf(word);

            }

            //text = text.Replace(word, replaceTo);

            return text;

        }

        static void Main(string[] args)
        {

            string s1 = "Welcome to Egypt , Egypt is a nice country";

            Console.WriteLine(s1);

            Console.WriteLine("\nText After Replaced: ");

            Console.WriteLine(ReplaceWordInStringUsingBuiltInFunction(s1, "Egypt", "USA"));

        }
    }
}