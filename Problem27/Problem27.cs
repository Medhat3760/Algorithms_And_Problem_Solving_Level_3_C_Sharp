namespace Problem27
{
    // Invert Character Case
    internal class Problem27
    {

        static char ReadCharacter(string message)
        {

            char c;

            Console.WriteLine(message);
            c = char.Parse(Console.ReadLine());

            return c;

        }

        static char InvertCharacterCase(char c)
        {

            return char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);

        }

        static void Main(string[] args)
        {

            char ch1 = ReadCharacter("Please Enter a Character?");

            Console.WriteLine("\nCharacter After Inverting Case:");
            ch1 = InvertCharacterCase(ch1);
            Console.WriteLine(ch1);

        }
    }
}