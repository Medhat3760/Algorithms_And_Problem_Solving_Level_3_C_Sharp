namespace Problem33
{
    // Count Vowels
    internal class Problem33
    {

        static string ReadString(string message)
        {

            string text = "";

            Console.WriteLine(message);
            text = Console.ReadLine();
            return text;

        }

        static bool IsVowel(char c)
        {

            c = char.ToLower(c);

            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');

        }

        static short CountVowels(string text)
        {

            short counter = 0;

            for (short i = 0; i < text.Length; i++)
            {

                if (IsVowel(text[i]))
                {
                    counter++;
                }

            }

            return counter;

        }

        static void Main(string[] args)
        {

            string s1 = ReadString("Please Enter Your String?");

            Console.WriteLine("\nNumber Of Vowels is: " + CountVowels(s1));

        }
    }
}