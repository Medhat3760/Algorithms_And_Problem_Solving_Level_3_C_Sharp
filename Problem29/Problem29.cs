namespace Problem29
{
    // Count Small/Capital Letters
    internal class Problem29
    {

        enum enWhatToCount { capitalLetters, smallLetter, All };

        static string ReadString(string message)
        {

            string text = "";

            Console.WriteLine(message);
            text = Console.ReadLine();
            return text;

        }

        static short CountLetters(string text, enWhatToCount whatToCount = enWhatToCount.All)
        {

            short counter = 0;

            switch (whatToCount)
            {

                case enWhatToCount.All:
                    return (short)text.Length;

                case enWhatToCount.capitalLetters:
                    for (short i = 0; i < text.Length; i++)
                    {
                        if (char.IsUpper(text[i]))
                            counter++;
                    }
                    return counter;

                case enWhatToCount.smallLetter:
                    for (short i = 0; i < text.Length; i++)
                    {
                        if (char.IsLower(text[i]))
                            counter++;
                    }
                    return counter;

                default:
                    return counter;

            }

        }

        static short CountCapitalLetters(string text)
        {

            short count = 0;

            for (short i = 0; i < text.Length; i++)
            {

                if (char.IsUpper(text[i]))
                {
                    count++;
                }

            }

            return count;

        }

        static short CountSmallLetters(string text)
        {

            short count = 0;

            for (short i = 0; i < text.Length; i++)
            {

                if (char.IsLower(text[i]))
                {
                    count++;
                }

            }

            return count;

        }

        static void Main()
        {

            string s1 = ReadString("Please Enter Your String?");

            Console.WriteLine("\nString Length = " + s1.Length);

            Console.WriteLine("\nCapital Letter Count = " + CountCapitalLetters(s1));

            Console.WriteLine("\nSmall Letter Count = " + CountSmallLetters(s1));

            Console.WriteLine("\n\nMethod 2:");

            Console.WriteLine("\nString Length = " + CountLetters(s1));

            Console.WriteLine("\nCapital Letter Count = " + CountLetters(s1, enWhatToCount.capitalLetters));

            Console.WriteLine("\nSmall Letter Count = " + CountLetters(s1, enWhatToCount.smallLetter));

        }
    }
}