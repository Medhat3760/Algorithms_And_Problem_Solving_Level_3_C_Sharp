namespace Problem47
{
    // Add Clients To File
    internal class Problem47
    {
        struct stClient
        {
            public string accountNumber;
            public string pinCode;
            public string name;
            public string phone;
            public double accountBalance;
        }

        static stClient ReadNewClient()
        {

            stClient client = new stClient();

            Console.Write("Enter Account Number? ");
            client.accountNumber = Console.ReadLine().Trim();

            Console.Write("Enter PIN Code? ");
            client.pinCode = Console.ReadLine();

            Console.Write("Enter Name? ");
            client.name = Console.ReadLine();

            Console.Write("Enter Phone? ");
            client.phone = Console.ReadLine();

            Console.Write("Enter Account Balance? ");
            client.accountBalance = double.Parse(Console.ReadLine());

            return client;

        }

        static string ConvertRecordToLine(stClient client, string separator = "#//#")
        {

            string line = "";

            line += client.accountNumber + separator;
            line += client.pinCode + separator;
            line += client.name + separator;
            line += client.phone + separator;
            line += client.accountBalance.ToString();

            return line;

        }

        static void AddDataLineToFile(string fileName, string dataLine)
        {

            using (StreamWriter writer = new StreamWriter(fileName, append: true))
            {

                writer.WriteLine(dataLine);

            }

        }

        static void AddNewClient(string fileName)
        {

            string dataLine = "";

            stClient client = ReadNewClient();

            dataLine = ConvertRecordToLine(client);

            AddDataLineToFile(fileName, dataLine);

        }

        static void AddClients(string fileName)
        {

            char addMore = 'Y';

            do
            {

                Console.Clear();

                Console.WriteLine("Adding a New Client:\n");

                AddNewClient(fileName);

                Console.Write("\nClient Added Successfuly, Do you want to add more clients? Y/N?");
                addMore = char.Parse(Console.ReadLine());


            } while (char.ToUpper(addMore) == 'Y');

        }

        static void Main(string[] args)
        {

            AddClients("Clients.txt");

        }
    }
}