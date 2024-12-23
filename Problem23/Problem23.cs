namespace Problem23
{
    // Print First Letter of Each Word
    internal class Problem23
    {

        static string ReadString(string message)
        {

            string text = "";

            Console.WriteLine(message);
            text = Console.ReadLine();

            return text;

        }

        static void PrintFirstLetterOfEachWord(string text)
        {

            Console.WriteLine("First Letter Of Each Word:");

            bool isFirstLetter = true;

            for (int i = 0; i < text.Length; i++)
            {

                if (text[i] != ' ' && isFirstLetter)
                {
                    Console.WriteLine(text[i]);
                }

                isFirstLetter = (text[i] == ' ') ? true : false;

            }

        }

        static void Main(string[] args)
        {
            PrintFirstLetterOfEachWord(ReadString("Please Enter Your String?"));
        }
    }
}