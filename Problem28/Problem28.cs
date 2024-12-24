namespace Problem28
{
    // Invert All Letters Case
    internal class Problem28
    {

        static char InvertCharacterCase(char ch)
        {

            return char.IsUpper(ch) ? char.ToLower(ch) : char.ToUpper(ch);

        }

        static string InvertAllLettersCase(string s1)
        {

            char[] arrChar = s1.ToCharArray();

            for (int i = 0; i < arrChar.Length; i++)
            {

                arrChar[i] = InvertCharacterCase(arrChar[i]);

            }

            s1 = new string(arrChar);

            return s1;

        }

        static void Main(string[] args)
        {

            string s1 = "abdelrahman MEDHAT";

            Console.WriteLine("Your String is:");
            Console.WriteLine(s1);

            Console.WriteLine("\nString After Inverting All Letters Case:");
            s1 = InvertAllLettersCase(s1);
            Console.WriteLine(s1);

        }
    }
}