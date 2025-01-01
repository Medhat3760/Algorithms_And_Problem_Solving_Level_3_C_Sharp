namespace Problem38
{
    // TrimLift, TrimRight, Trim
    internal class Problem38
    {

        static string ReadString(string message)
        {

            string text;

            Console.WriteLine(message);
            text = Console.ReadLine();

            return text;

        }

        static string TrimLift(string text)
        {

            for (short i = 0; i < text.Length; i++)
            {

                if (text[i] != ' ')
                {
                    return text.Substring(i, text.Length - i);
                }

            }

            return "";

        }

        static string TrimRight(string text)
        {

            for (short i = (short)(text.Length - 1); i > 0; i--)
            {

                if (text[i] != ' ')
                {
                    return text = text.Substring(0, i + 1);
                }

            }

            return "";

        }

        static string Trim(string text)
        {

            return TrimLift(TrimRight(text));

        }

        static void Main(string[] args)
        {

            string s1 = ReadString("Please Enter Your String?");

            Console.WriteLine("Trim Lift = " + TrimLift(s1));

            Console.WriteLine("Trim Right = " + TrimRight(s1));

            Console.WriteLine("Trim = " + Trim(s1));

        }
    }
}