namespace Problem35_version2
{
    // Print Each Word In String
    internal class Problem35_version2
    {

        static string ReadString(string message)
        {

            string text;

            Console.WriteLine(message);
            text = Console.ReadLine();

            return text;

        }

        static void PrintEachWordInString(string text)
        {

            Console.WriteLine("\nYour string words are: ");

            for (short i = 0; i < text.Length; i++)
            {

                if (text[i] == ' ')
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(text[i]);
                }

            }

        }

        static void Main(string[] args)
        {

            PrintEachWordInString(ReadString("Please Enter Your Text?"));

        }
    }
}