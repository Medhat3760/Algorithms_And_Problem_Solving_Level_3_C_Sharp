namespace Problem35
{
    // Print Each Word In String
    internal class Problem35
    {

        static string ReadString(string message)
        {

            string s1;

            Console.WriteLine(message);
            s1 = Console.ReadLine();

            return s1;

        }

        static void PrintEachWordInString(string s1)
        {

            Console.WriteLine("\nYour string words are: ");

            string delim = " "; // Delimiter 

            short pos = 0;

            string sWord = "";

            while ((pos = (short)s1.IndexOf(delim)) != -1)
            {

                sWord = s1.Substring(0, pos);

                if (sWord != "")
                {
                    Console.WriteLine(sWord);
                }

                s1 = s1.Substring(pos + delim.Length);

            }

            if (s1 != "")
            {
                Console.WriteLine(s1); // it print last word of the string.
            }

        }

        static void Main(string[] args)
        {

            string s1 = ReadString("\nPlease Enter Your String?");

            PrintEachWordInString(s1);

        }
    }
}
