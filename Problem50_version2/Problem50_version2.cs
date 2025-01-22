namespace Problem50_version2
{
    // Delete Client By Account Number
    internal class Problem50_version2
    {

        struct stClient
        {

            public string accountNumber;
            public string pinCode;
            public string name;
            public string phone;
            public double accountBalance;
            public bool markForDelete;

        }

        static string ReadAccountNumber()
        {

            string accountNumber = "";

            Console.Write("Please Enter Account Number? ");

            accountNumber = Console.ReadLine();

            return accountNumber;

        }

        static List<string> SplitString(string text, string delim)
        {

            List<string> lWord = new List<string>();

            string sWord = "";
            short pos = 0;

            while ((pos = (short)text.IndexOf(delim)) != -1)
            {

                sWord = text.Substring(0, pos);

                if (sWord != "")
                {

                    lWord.Add(sWord);

                }

                text = text.Substring(pos + delim.Length);

            }

            if (text != "")
            {
                lWord.Add(text);
            }

            return lWord;

        }

        static stClient ConvertLineToRecord(string dataLine, string separator = "#//#")
        {

            stClient client;

            List<string> lClientData = SplitString(dataLine, separator);

            client.accountNumber = lClientData[0];
            client.pinCode = lClientData[1];
            client.name = lClientData[2];
            client.phone = lClientData[3];
            client.accountBalance = double.Parse(lClientData[4]);
            client.markForDelete = false;

            return client;

        }

        static List<stClient> LoadClientsFromFile(string fileName)
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

                        client = ConvertLineToRecord(dataLine);

                        lClients.Add(client);

                    }

                }

            }

            return lClients;

        }

        static bool FindClientByAccountNumber(string fileName, string accountNumber, ref stClient client)
        {

            List<stClient> lClients = LoadClientsFromFile(fileName);

            foreach (stClient c in lClients)
            {

                if (c.accountNumber == accountNumber)
                {

                    client = c;

                    return true;

                }

            }

            return false;

        }

        static void PrintClient(stClient client)
        {

            Console.WriteLine("\nThe following are the client details:\n");

            Console.WriteLine("Account Number : " + client.accountNumber);
            Console.WriteLine("Pin Code       : " + client.pinCode);
            Console.WriteLine("Name           : " + client.name);
            Console.WriteLine("phone          : " + client.phone);
            Console.WriteLine("Account Balance: " + client.accountBalance.ToString());

        }

        static void MarkClientForDeleteByAccountNumber(string accountNumber, ref List<stClient> lClients)
        {

            for (int i = 0; i < lClients.Count; i++)
            {

                if (lClients[i].accountNumber == accountNumber)
                {

                    stClient c = lClients[i];

                    c.markForDelete = true;

                    lClients[i] = c;

                    break;

                }

            }

        }

        static string ConvertRecordToLine(stClient client, string separator = "#//#")
        {

            string dataLine = "";

            dataLine += client.accountNumber + separator;
            dataLine += client.pinCode + separator;
            dataLine += client.name + separator;
            dataLine += client.phone + separator;
            dataLine += client.accountBalance.ToString();

            return dataLine;

        }

        static void SaveClientsDataToFile(string fileName, List<stClient> lClients)
        {

            if (File.Exists(fileName))
            {

                using (StreamWriter writer = new StreamWriter(fileName))
                {

                    string dataLine = "";

                    foreach (stClient c in lClients)
                    {

                        if (!c.markForDelete)
                        {

                            dataLine = ConvertRecordToLine(c);

                            writer.WriteLine(dataLine);

                        }

                    }

                }

            }

        }

        static void DeleteClientByAccountNumber(string fileName, string accountNumber, ref List<stClient> lClients)
        {

            stClient client = new stClient();

            if (FindClientByAccountNumber(fileName, accountNumber, ref client))
            {

                char confirm = 'N';

                PrintClient(client);

                Console.Write("\nAre you sur you want delete this client? Y/N ? ");
                confirm = char.Parse(Console.ReadLine());

                if (char.ToUpper(confirm) == 'Y')
                {

                    MarkClientForDeleteByAccountNumber(accountNumber, ref lClients);

                    SaveClientsDataToFile(fileName, lClients);

                    // Refresh clients List
                    lClients = LoadClientsFromFile(fileName);

                    Console.WriteLine("\n Client Deleted Successfully.");

                }

            }
            else
            {
                Console.WriteLine($"\nClient with Account Number ({accountNumber}) is Not Found!");
            }

        }

        static void Main(string[] args)
        {

            List<stClient> lClients = LoadClientsFromFile("Clients.txt");

            string accountNumber = ReadAccountNumber();

            DeleteClientByAccountNumber("Clients.txt", accountNumber, ref lClients);

        }

    }
}
