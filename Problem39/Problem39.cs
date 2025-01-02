namespace Problem39
{
    // Join String
    internal class Problem39
    {

        static string JoinString(List<string> lString, string delim)
        {

            string str = "";

            for (short i = 0; i < lString.Count; i++)
            {
                str += lString[i];

                if (i != lString.Count - 1)
                    str += delim;
            }

            return str;

        }

        static void Main(string[] args)
        {

            List<string> lString = new List<string> { "Abdelrahman", "Medhat", "Rushdy" };

            Console.WriteLine("\nList after join: \n" + JoinString(lString, ","));

        }
    }
}