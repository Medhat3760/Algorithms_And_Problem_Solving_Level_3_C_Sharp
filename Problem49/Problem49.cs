namespace Problem49
{
    // Find Client By Account Number
    internal class Problem49
    {

        struct stClient
        {

            public string accountNumber;
            public string pinCode;
            public string name;
            public string phone;
            public double accountBalance;

        }

        static string ReadClientAccountNumber()
        {

            string accountNumber = "";

            Console.Write("Please Enter Account Number? ");

            accountNumber = Console.ReadLine();

            return accountNumber;

        }

        static List<string> SplitString(string line, string separator)
        {

            List<string> lString = new List<string>();

            string sWord = "";
            short pos = 0;

            while ((pos = (short)line.IndexOf(separator)) != -1)
            {

                sWord = line.Substring(0, pos);

                if (sWord != "")
                {

                    lString.Add(sWord);

                }

                line = line.Substring(pos + separator.Length);

            }

            if (line != "")
            {

                lString.Add(line);

            }

            return lString;

        }

        static stClient ConvertLineToRecord(string line, string separator = "#//#")
        {

            stClient client;

            List<string> lClientData = SplitString(line, separator);

            client.accountNumber = lClientData[0];
            client.pinCode = lClientData[1];
            client.name = lClientData[2];
            client.phone = lClientData[3];
            client.accountBalance = double.Parse(lClientData[4]);

            return client;

        }

        static List<stClient> LoadClientsDataFromFileToList(string fileName)
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
            else
            {
                Console.WriteLine("\nFile Not Found");
            }

            return lClients;

        }

        static void PrintClientCard(stClient client)
        {

            Console.WriteLine("\nThe following are the client details:\n");
            Console.WriteLine("Account Number : " + client.accountNumber);
            Console.WriteLine("Pin Code       : " + client.pinCode);
            Console.WriteLine("Name           : " + client.name);
            Console.WriteLine("Phone          : " + client.phone);
            Console.WriteLine("Account Balance: " + client.accountBalance.ToString());

        }

        static bool FindClientByAccountNumber(string fileName, string accountNumber, ref stClient client)
        {

            List<stClient> lClients = LoadClientsDataFromFileToList(fileName);

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

        static void Main(string[] args)
        {

            stClient client = new stClient();

            string accountNumber = ReadClientAccountNumber();

            if (FindClientByAccountNumber("Clients.txt", accountNumber, ref client))
            {

                PrintClientCard(client);

            }
            else
            {
                Console.WriteLine($"\nClient with Account Number ({accountNumber}) is Not Found!");
            }

        }
    }
}