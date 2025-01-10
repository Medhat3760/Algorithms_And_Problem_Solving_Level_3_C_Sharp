namespace Problem44_version2
{
    // Remove Punctuation
    internal class Problem44_version2
    {

        static string RemovePunctuationsFromString(string text)
        {

            char[] charArr = text.ToCharArray();

            string text2 = "";

            for (short i = 0; i < charArr.Length; i++)
            {

                if (!char.IsPunctuation(charArr[i]))
                {
                    text2 += charArr[i];
                }

            }

            return text2;

        }

        static void Main(string[] args)
        {

            string s1 = "Welcome to Jordan, Jordan is a nice country; it's amazing.";

            Console.WriteLine("\nOriginal String:\n" + s1);

            Console.WriteLine("\nPunctuation Removed:\n" + RemovePunctuationsFromString(s1));

        }
    }
}