namespace Problem34
{
    // Print All Vowels In a String
    internal class Problem34
    {

        static string ReadString(string message)
        {

            string s1;

            Console.WriteLine(message);
            s1 = Console.ReadLine();

            return s1;

        }

        static bool IsVowel(char ch1)
        {

            ch1 = char.ToLower(ch1);

            return (ch1 == 'a' || ch1 == 'e' || ch1 == 'o' || ch1 == 'i' || ch1 == 'u');

        }

        static void PrintVowels(string s1)
        {

            Console.Write("\nVowels in string are: ");

            for (short i = 0; i < s1.Length; i++)
            {

                if (IsVowel(s1[i]))
                {
                    Console.Write(s1[i] + "  ");
                }

            }

            Console.WriteLine();

        }

        static void Main()
        {

            string s1 = ReadString("\nPlease Enter Your String?");

            PrintVowels(s1);

        }
    }
}