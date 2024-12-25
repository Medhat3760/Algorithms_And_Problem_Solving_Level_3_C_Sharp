namespace Problem32
{
    // Is Vowel
    internal class Problem32
    {

        static char ReadChar(string message)
        {

            char c;
            Console.WriteLine(message);
            while (!char.TryParse(Console.ReadLine(), out c) || char.IsWhiteSpace(c))
            {

                Console.WriteLine("Invalid input, Please enter a single character:");

            }

            return c;

        }

        static bool IsVowel(char c)
        {

            c = char.ToLower(c);

            return (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u');

        }

        static void Main(string[] args)
        {

            char c1 = ReadChar("Please Enter Your Character?");

            if (IsVowel(c1))
            {
                Console.WriteLine($"\nYes: Letter '{c1}' is vowel.");
            }
            else
            {
                Console.WriteLine($"\nNo: Letter '{c1}' is NOT vowel.");
            }

        }
    }
}