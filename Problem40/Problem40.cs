namespace Problem40
{
    // Join String ( Overloading )
    internal class Problem40
    {

        static string JoinString(List<string> lString, string delim)
        {

            string str = "";

            foreach (string s in lString)
            {
                str += s + delim;
            }

            return str.Substring(0, str.Length - delim.Length);

        }

        static string JoinString(string[] arrString, string delim)
        {

            string str = "";

            for (short i = 0; i < arrString.Length; i++)
            {
                str += arrString[i] + delim;
            }

            return str.Substring(0, str.Length - delim.Length);

        }

        static void Main(string[] args)
        {

            List<string> lString = new List<string> { "Abdelrahman", "Medhat", "Rushdy" };

            string[] arrString = { "Abdelrahman", "Medhat", "Rushdy" };

            Console.WriteLine("\nList after join:\n" + JoinString(lString, " "));

            Console.WriteLine("\nArr after join:\n" + JoinString(arrString, " "));

        }
    }
}