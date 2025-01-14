using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Problem48
{
    // Show All Clients
    internal class Problem48
    {

        struct stClient
        {

            public string accountNumber;
            public string pinCode;
            public string name;
            public string phone;
            public double accountBalance;

        }

        static List<string> SplitString(string text, string delim)
        {

            List<string> lString = new List<string>();

            string sWord = "";
            short pos = 0;

            while ((pos = (short)text.IndexOf(delim)) != -1)
            {

                sWord = text.Substring(0, pos);

                if (sWord != "")
                {
                    lString.Add(sWord);
                }

                text = text.Substring(pos + delim.Length);

            }

            if (text != "")
            {
                lString.Add(text);
            }

            return lString;

        }

        static stClient ConvertLineDataToRecord(string dataLine, string separator = "#//#")
        {

            stClient client;

            List<string> lRecordData = SplitString(dataLine, separator);

            client.accountNumber = lRecordData[0];
            client.pinCode = lRecordData[1];
            client.name = lRecordData[2];
            client.phone = lRecordData[3];
            client.accountBalance = double.Parse(lRecordData[4]);

            return client;

        }

        static List<stClient> LoadClientsFromFileToList(string fileName)
        {

            List<stClient> lClients = new List<stClient>();

            if (File.Exists(fileName))
            {

                using (StreamReader reader = new StreamReader(fileName))
                {

                    string dataLine = "";
                    stClient client;

                    while ((dataLine = reader.ReadLine()) != null)
                    {

                        client = ConvertLineDataToRecord(dataLine);
                        lClients.Add(client);

                    }

                }

            }
            else
            {
                Console.WriteLine("File doesn't Exist");
            }

            return lClients;

        }

        static void PrintClientTableHeader()
        {

            Console.WriteLine("\n___________________________________________________________________________________________________\n");

            Console.Write("| " + "Accoun Number".PadRight(16));
            Console.Write("| " + "Pin Code".PadRight(11));
            Console.Write("| " + "Client Name".PadRight(40));
            Console.Write("| " + "Phone".PadRight(12));
            Console.Write("| " + "Balance".PadRight(12));

            Console.WriteLine("\n___________________________________________________________________________________________________\n");


        }

        static void PrintClientRecord(stClient client)
        {

            Console.Write($"| {client.accountNumber.PadRight(16)}");
            Console.Write($"| {client.pinCode.PadRight(11)}");
            Console.Write($"| {client.name.PadRight(40)}");
            Console.Write($"| {client.phone.PadRight(12)}");
            Console.Write($"| {client.accountBalance.ToString().PadRight(12)}");

        }

        static void PrintAllClientsData(List<stClient> lClients)
        {

            Console.Write($"\t\t\tClient List ({lClients.Count}) Client(s)");

            PrintClientTableHeader();

            foreach (stClient client in lClients)
            {

                PrintClientRecord(client);
                Console.WriteLine();

            }

            Console.WriteLine("\n___________________________________________________________________________________________________\n");

        }

        static void Main(string[] args)
        {

            List<stClient> clients = LoadClientsFromFileToList("Clients.txt");

            PrintAllClientsData(clients);

        }
    }
}