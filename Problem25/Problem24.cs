namespace Problem24
{
    // Upper First Letter Of Each Word
    internal class Problem24
    {

        static string ReadString(string message)
        {

            string text = "";

            Console.WriteLine(message);
            text = Console.ReadLine();
            return text;
        }

        static string UpperFirstLetterOfEachWord(string text)
        {

            char[] arrChar = text.ToCharArray();

            bool isFirstLetter = true;

            for (int i = 0; i < arrChar.Length; i++)
            {

                if (arrChar[i] != ' ' && isFirstLetter)
                {

                    arrChar[i] = char.ToUpper(arrChar[i]);

                }

                isFirstLetter = (arrChar[i] == ' ') ? true : false;

            }

            return new string(arrChar);

        }

        static void Main(string[] args)
        {

            string s1 = ReadString("Please Enter Your String?");

            Console.WriteLine("\nString After Conversion:");
            s1 = UpperFirstLetterOfEachWord(s1);
            Console.WriteLine(s1);

        }
    }
}