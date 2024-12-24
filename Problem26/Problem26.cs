namespace Problem26
{
    // Upper/Lower All Letter Of a String
    internal class Problem26
    {

        static string ReadString(string message)
        {

            string text = "";

            Console.WriteLine(message);
            text = Console.ReadLine();
            return text;

        }

        static string UpperAllString(string text)
        {

            char[] arrChar = text.ToCharArray();

            for (int i = 0; i < arrChar.Length; i++)
            {

                arrChar[i] = char.ToUpper(arrChar[i]);

            }

            return new string(arrChar);

        }

        static string LowerAllString(string text)
        {

            char[] arrChar = text.ToCharArray();

            for (int i = 0; i < arrChar.Length; i++)
            {

                arrChar[i] = char.ToLower(arrChar[i]);

            }

            return new string(arrChar);

        }

        static void Main(string[] args)
        {

            string s1 = ReadString("Please Enter Your String?");

            Console.WriteLine("\nString After Upper:");
            s1 = UpperAllString(s1);
            Console.WriteLine(s1);

            Console.WriteLine("\nString After Lower:");
            s1 = LowerAllString(s1);
            Console.WriteLine(s1);

        }
    }
}