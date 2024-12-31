namespace Problem36
{
    // Count Each Word In String
    internal class Problem36
    {

        static string ReadString(string message)
        {

            string text;

            Console.WriteLine(message);
            text = Console.ReadLine();

            return text;

        }

        static short CountWords(string text)
        {

            short counter = 0;

            string word = "";

            string delim = " ";

            short pos = 0;

            while ((pos = (short)text.IndexOf(delim)) != -1)
            {
                word = text.Substring(0, pos);

                if (word != "")
                {
                    counter++;
                }

                text = text.Substring(pos + delim.Length);

            }

            if (text != "")
            {
                counter++;
            }

            return counter;

        }

        static void Main(string[] args)
        {

            string s1 = ReadString("Please Enter Your String?");

            Console.WriteLine("\nNumber Of Words: " + CountWords(s1));

        }
    }
}