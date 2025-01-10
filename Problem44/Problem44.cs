namespace Problem44
{
    // Remove Punctuation
    internal class Problem44
    {

        static string RemovePunctuations(string text)
        {

            char[] charArr = text.ToCharArray();

            for (short i = 0; i < charArr.Length; i++)
            {

                if (char.IsPunctuation(charArr[i]))
                {
                    charArr[i] = '\0';
                }

            }

            return new string(charArr);

        }

        static void Main(string[] args)
        {

            string s1 = "Welcome to Jordan, Jordan is a nice country; it's amazing.";

            Console.WriteLine("\nOriginal String:\n" + s1);

            Console.WriteLine("\nPunctuation Removed:\n" + RemovePunctuations(s1));

        }
    }
}