namespace Problem50
{
    // Delete Client By Account Number
    internal class Problem50
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

        static stClient ConvertLineToRecord(string line, string separator = "#//#")
        {

            stClient client = new stClient();

            List<string> lClientData = SplitString(line, separator);

            client.accountNumber = lClientData[0];
            client.pinCode = lClientData[1];
            client.name = lClientData[2];
            client.phone = lClientData[3];
            client.accountBalance = double.Parse(lClientData[4]);

            return client;

        }

        static List<stClient> LoadClientsFromFileToList(string fileName)
        {

            List<stClient> clientList = new List<stClient>();

            if (File.Exists(fileName))
            {

                using (StreamReader reader = new StreamReader(fileName))
                {

                    stClient client;

                    string dataLine = "";

                    while ((dataLine = reader.ReadLine()) != null)
                    {

                        client = ConvertLineToRecord(dataLine);

                        clientList.Add(client);

                    }

                }

            }
            else
            {
                Console.WriteLine($"The file '{fileName}' does not exist.");
            }

            return clientList;

        }

        static bool FindClientByAccountNumber(string fileName, string accountNumber, ref stClient client)
        {

            List<stClient> clientList = new List<stClient>();

            clientList = LoadClientsFromFileToList(fileName);

            foreach (stClient c in clientList)
            {

                if (c.accountNumber == accountNumber)
                {

                    client = c;

                    return true;

                }

            }

            return false;

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

        static List<string> LoadDataFromfileToList(string fileName)
        {

            List<string> lFileContent = new List<string>();

            if (File.Exists(fileName))
            {

                using (StreamReader reader = new StreamReader(fileName))
                {

                    string line = "";

                    while ((line = reader.ReadLine()) != null)
                    {

                        lFileContent.Add(line);

                    }

                }

            }

            return lFileContent;

        }

        static void SaveListToFile(string fileName, List<string> lFileContent)
        {

            if (File.Exists(fileName))
            {

                using (StreamWriter wtiter = new StreamWriter(fileName))
                {

                    foreach (string dataLine in lFileContent)
                    {

                        if (dataLine != "")
                        {
                            wtiter.WriteLine(dataLine);
                        }

                    }

                }

            }

        }

        static void DeleteRecordFromFile(string fileName, string record)
        {

            List<string> lFileContent = LoadDataFromfileToList(fileName);

            for (int i = 0; i < lFileContent.Count; i++)
            {

                if (lFileContent[i].IndexOf(record) != -1)
                {
                    lFileContent[i] = "";
                }

            }

            SaveListToFile(fileName, lFileContent);

        }

        static void DeleteClientByAccountNumber(string fileName, string accountNumber)
        {

            stClient client = new stClient();

            char confirm = 'Y';

            if (FindClientByAccountNumber(fileName, accountNumber, ref client))
            {

                PrintClientCard(client);

                Console.Write("\nAre you sure you want to delete this client ? Y/N ? ");
                confirm = char.Parse(Console.ReadLine());

                if (char.ToUpper(confirm) == 'Y')
                {

                    string recordLine = ConvertRecordToLine(client);

                    DeleteRecordFromFile(fileName, recordLine);

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

            string accountNumber = ReadClientAccountNumber();

            DeleteClientByAccountNumber("Clients.txt", accountNumber);

        }
    }
}