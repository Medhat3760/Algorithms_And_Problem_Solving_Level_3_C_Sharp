using System.Text;

namespace Problem44_version3
{
    // Remove Punctuation
    internal class Problem44_version3
    {

        static string RemovePunctuationsOptimized(string text)
        {
            StringBuilder sb = new StringBuilder();

            foreach (char c in text)
            {
                if (!char.IsPunctuation(c))
                {
                    sb.Append(c);
                }
            }

            return sb.ToString();
        }

        static void Main(string[] args)
        {

            string s1 = "Welcome to Jordan, Jordan is a nice country; it's amazing.";

            Console.WriteLine("\nOriginal String:\n" + s1);

            Console.WriteLine("\nPunctuation Removed:\n" + RemovePunctuationsOptimized(s1));

        }
    }
}