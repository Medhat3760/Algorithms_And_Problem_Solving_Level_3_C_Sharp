namespace Problem25
{
    // Lower First Letter Of Each Word
    internal class Problem25
    {

        static string ReadString(string message)
        {

            string text = "";

            Console.WriteLine(message);
            text = Console.ReadLine();
            return text;

        }

        static string LowerFirstLetterOfEachWord(string text)
        {

            char[] arrChar = text.ToCharArray();

            bool isFirstLetter = true;

            for (int i = 0; i < arrChar.Length; i++)
            {

                if (arrChar[i] != ' ' && isFirstLetter)
                {
                    arrChar[i] = char.ToLower(arrChar[i]);
                }

                isFirstLetter = (arrChar[i] == ' ') ? true : false;

            }

            return new string(arrChar);

        }

        static void Main(string[] args)
        {

            string s1 = ReadString("Please Enter Your String?");

            Console.WriteLine("\nString After Conversion:");
            s1 = LowerFirstLetterOfEachWord(s1);
            Console.WriteLine(s1);

        }
    }
}