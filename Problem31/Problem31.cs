namespace Problem31
{
    // Count Letters ( Match Case )
    internal class Problem31
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

        static char InvertLetterCase(char c)
        {

            return char.IsUpper(c) ? char.ToLower(c) : char.ToUpper(c);

        }

        static short CountSpecificLetter(string text, char letter, bool matchCase = true)
        {

            short counter = 0;

            for (short i = 0; i < text.Length; i++)
            {
                if (matchCase)
                {
                    if (text[i] == letter)
                    {
                        counter++;
                    }
                }
                else
                {

                    if (char.ToLower(text[i]) == char.ToLower(letter))
                    {
                        counter++;
                    }

                }
            }

            return counter;

        }

        static void Main(string[] args)
        {

            string s1 = ReadString("Please Enter Your String?");

            char c1 = ReadChar("\nPlease Enter Your Character?");

            Console.WriteLine("\nLetter '" + c1 + "' Count = " + CountSpecificLetter(s1, c1));

            Console.WriteLine($"\nLetter '{c1}' and '{InvertLetterCase(c1)}' Count = " + CountSpecificLetter(s1, c1, false));

        }
    }
}