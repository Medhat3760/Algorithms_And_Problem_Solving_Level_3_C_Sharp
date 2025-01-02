namespace Problem39_version2
{
    // Join String
    internal class Problem39_version2
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

        static void Main(string[] args)
        {

            List<string> lString = new List<string> { "Abdelrahman", "Medhat", "Rushdy" };

            Console.WriteLine("\nList after join: \n" + JoinString(lString, ","));

        }
    }
}