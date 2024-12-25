namespace Problem30
{
    // Count Letter
    internal class Problem30
    {

        static string ReadString(string message)
        {

            string text = "";

            Console.WriteLine(message);
            text = Console.ReadLine();
            return text;

        }

        static char ReadChar(string message)
        {

            char c;

            Console.WriteLine(message);
            c = char.Parse(Console.ReadLine());

            return c;

        }

        static short CountSpecificLetter(string text, char letter)
        {
            short counter = 0;
            for (short i = 0; i < text.Length; i++)
            {

                if (text[i] == letter)
                {
                    counter++;
                }

            }

            return counter;

        }

        static void Main()
        {

            string s1 = ReadString("Please Enter Your String?");

            char c1 = ReadChar("\nPlease Enter Your Character?");

            Console.WriteLine("\nLetter '" + c1 + "' Count = " + CountSpecificLetter(s1, c1));

        }
    }
}