namespace Bank_Extension
{
    internal class Bank_Extension
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

        enum enMainMenuOptions
        {
            eListClients = 1, eAddNewClient = 2, eDeleteClient = 3,
            eUpdateClient = 4, eFindClient = 5, eTransactions = 6, eExit = 7
        }

        static List<string> SplitString(string s, string delim)
        {

            List<string> lString = new List<string>();

            string sWord = "";
            short pos = 0;

            while ((pos = (short)s.IndexOf(delim)) != -1)
            {

                sWord = s.Substring(0, pos);

                if (sWord != "")
                {
                    lString.Add(sWord);
                }

                s = s.Substring(pos + delim.Length);

            }

            if (s != "")
            {
                lString.Add(s);
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

        static List<stClient> LoadClientsDataFromFile(string fileName)
        {

            List<stClient> lClients = new List<stClient>();

            if (File.Exists(fileName))
            {

                using (StreamReader reader = new StreamReader(fileName))
                {

                    string line = "";
                    stClient client;

                    while ((line = reader.ReadLine()) != null)
                    {

                        client = ConvertLineToRecord(line);

                        lClients.Add(client);

                    }

                }

            }
            else
            {
                Console.WriteLine($"The file with name {fileName} not found!.");
            }

            return lClients;

        }

        static void PrintClientRecordLine(stClient client)
        {

            Console.Write($"| {client.accountNumber.PadRight(15)}");
            Console.Write($"| {client.pinCode.PadRight(9)}");
            Console.Write($"| {client.name.PadRight(40)}");
            Console.Write($"| {client.phone.PadRight(12)}");
            Console.Write($"| {client.accountBalance.ToString().PadRight(12)}");

        }

        static void ShowClientList(string fileName)
        {

            List<stClient> lClients = LoadClientsDataFromFile(fileName);

            Console.WriteLine($"\n\t\t\t Client List ({lClients.Count}) Client(s).");

            Console.WriteLine("__________________________________________________________________________________________________________\n");
            Console.Write($"| {"Account Number".PadRight(15)}");
            Console.Write($"| {"Pin Code".PadRight(9)}");
            Console.Write($"| {"Client Name".PadRight(40)}");
            Console.Write($"| {"Phone".PadRight(12)}");
            Console.Write($"| {"Account Balance".PadRight(12)}\n");
            Console.WriteLine("__________________________________________________________________________________________________________\n");

            if (lClients.Count == 0)
            {

                Console.WriteLine("\t\t\t\tNo Clients Available In The System!");

            }
            else
            {

                foreach (stClient client in lClients)
                {

                    PrintClientRecordLine(client);

                    Console.WriteLine();

                }

            }

            Console.WriteLine("\n__________________________________________________________________________________________________________\n");

        }

        static stClient ReadNewClient()
        {

            stClient client = new stClient();

            Console.Write("\nPlease Enter Account Number? ");
            client.accountNumber = Console.ReadLine().Trim();

            Console.Write("Please Enter Pin Code? ");
            client.pinCode = Console.ReadLine();

            Console.Write("Please Enter Name? ");
            client.name = Console.ReadLine();

            Console.Write("Please Enter Phone? ");
            client.phone = Console.ReadLine();

            Console.Write("Please Enter Client Balance? ");
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

        static void SaveClientsListToFile(string fileName, List<stClient> lClients)
        {

            if (File.Exists(fileName))
            {

                using (StreamWriter writer = new StreamWriter(fileName))
                {

                    string line = "";

                    foreach (stClient c in lClients)
                    {

                        if (!c.markForDelete)
                        {

                            line = ConvertRecordToLine(c);

                            writer.WriteLine(line);

                        }

                    }

                }

            }
            else
            {
                Console.WriteLine($"The file with name {fileName} not found!.");
            }

        }

        static bool ClientExistsByAccountNumber(string fileName, string accountNumber)
        {

            if (File.Exists(fileName))
            {

                using (StreamReader reader = new StreamReader(fileName))
                {

                    string line = "";
                    stClient client;

                    while ((line = reader.ReadLine()) != null)
                    {

                        client = ConvertLineToRecord(line);

                        if (client.accountNumber == accountNumber)
                        {
                            return true;
                        }

                    }

                }

            }

            return false;

        }

        static stClient ReadNewClient(string fileName)
        {

            stClient client = new stClient();

            client.accountNumber = ReadAccountNumber();

            while (ClientExistsByAccountNumber(fileName, client.accountNumber))
            {

                Console.Write($"\nClient with [{client.accountNumber}] already exists, Enter another Account Number ? ");
                client.accountNumber = Console.ReadLine().Trim();

            }


            Console.Write("\nPlease Enter Pin Code? ");
            client.pinCode = Console.ReadLine();

            Console.Write("Please Enter Name? ");
            client.name = Console.ReadLine();

            Console.Write("Please Enter Phone? ");
            client.phone = Console.ReadLine();

            Console.Write("Please Enter Account Balance? ");
            client.accountBalance = double.Parse(Console.ReadLine());

            return client;

        }

        static void AddDataLineToFile(string fileName, string dataLine)
        {

            if (File.Exists(fileName))
            {

                using (StreamWriter writer = new StreamWriter(fileName, append: true))
                {

                    writer.WriteLine(dataLine);

                }

            }

        }

        static void AddNewClient(string fileName)
        {

            string dataLine = "";

            stClient client = ReadNewClient(fileName);

            dataLine = ConvertRecordToLine(client);

            AddDataLineToFile(fileName, dataLine);

        }

        static void AddNewClients(string fileName)
        {

            char addMore = 'N';

            do
            {

                Console.WriteLine("\nAdding New Client:\n");

                AddNewClient(fileName);

                Console.Write("\n Client Added Successfully, Do you want to add more clients? Y/N? ");
                addMore = char.Parse(Console.ReadLine());

            } while (char.ToUpper(addMore) == 'Y');

        }

        static void ShowAddNewClientsScreen(string fileName)
        {

            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("\t\tAdd New Clients Screen");
            Console.WriteLine("------------------------------------------------------");

            AddNewClients(fileName);

        }

        static string ReadAccountNumber()
        {

            string accountNumber = "";

            Console.Write("\nPlease Enter Account Number? ");
            accountNumber = Console.ReadLine().Trim();

            return accountNumber;

        }

        static bool FindClientByAccountNumber(string fileName, string accountNumber, List<stClient> lClients, ref stClient client)
        {

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

        static void PrintClientCard(stClient client)
        {

            Console.WriteLine("\nThe following are the client details:");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Account Number : " + client.accountNumber);
            Console.WriteLine("Pin Code       : " + client.pinCode);
            Console.WriteLine("Name           : " + client.name);
            Console.WriteLine("phone          : " + client.phone);
            Console.WriteLine("Account Balance: " + client.accountBalance.ToString());
            Console.WriteLine("------------------------------------------");

        }

        static void MarkClientForDelete(string accountNumber, ref List<stClient> lClients)
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

        static void DeleteClientByAccountNumber(string fileName, string accountNumber, ref List<stClient> lClients)
        {

            stClient client = new stClient();

            if (FindClientByAccountNumber(fileName, accountNumber, lClients, ref client))
            {

                char confirm = 'N';

                PrintClientCard(client);

                Console.Write("\nAre you sure you want to delete this client? Y/N? ");
                confirm = char.Parse(Console.ReadLine());

                if (char.ToUpper(confirm) == 'Y')
                {

                    MarkClientForDelete(accountNumber, ref lClients);

                    SaveClientsListToFile(fileName, lClients);

                    // Refresh Clients List
                    lClients = LoadClientsDataFromFile(fileName);

                    Console.WriteLine("\n Client Deleted Successfully.");

                }

            }
            else
            {
                Console.WriteLine($"\nClient with Account Number ({accountNumber}) is Not Found!");
            }

        }

        static void ShowDeleteClientScreen(string fileName)
        {

            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("\t\tDelete Client Screen");
            Console.WriteLine("------------------------------------------------------");

            List<stClient> lClients = LoadClientsDataFromFile(fileName);

            string accountNumber = ReadAccountNumber();

            DeleteClientByAccountNumber(fileName, accountNumber, ref lClients);

        }

        static stClient ChangeClientRecord(string accountNumber)
        {

            stClient client = new stClient();

            client.accountNumber = accountNumber;

            Console.Write("\nPlease Enter Pin Code? ");
            client.pinCode = Console.ReadLine().Trim();

            Console.Write("Please Enter Name? ");
            client.name = Console.ReadLine();

            Console.Write("Please Enter Phone? ");
            client.phone = Console.ReadLine();

            Console.Write("Please Enter Account Balance? ");
            client.accountBalance = double.Parse(Console.ReadLine());

            return client;

        }

        static void UpdateClientByAccountNumber(string fileName, string accountNumber, ref List<stClient> lClients)
        {

            stClient client = new stClient();

            if (FindClientByAccountNumber(fileName, accountNumber, lClients, ref client))
            {

                char confirm = 'N';

                PrintClientCard(client);

                Console.Write("\nAre you sure you want to update this client? Y/N? ");
                confirm = char.Parse(Console.ReadLine());

                if (char.ToUpper(confirm) == 'Y')
                {

                    for (int i = 0; i < lClients.Count; i++)
                    {

                        if (lClients[i].accountNumber == accountNumber)
                        {

                            lClients[i] = ChangeClientRecord(accountNumber);

                            break;

                        }

                    }

                    SaveClientsListToFile(fileName, lClients);

                }

            }
            else
            {
                Console.WriteLine($"\nClient with Account Number ({accountNumber}) is Not Found!");
            }

        }

        static void ShowUpdateClientScreen(string fileName)
        {

            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("\t\tUpdate Client Info Screen");
            Console.WriteLine("------------------------------------------------------");

            List<stClient> lClients = LoadClientsDataFromFile(fileName);

            string accountNumber = ReadAccountNumber();

            UpdateClientByAccountNumber(fileName, accountNumber, ref lClients);

        }

        static void ShowFindClientScreen(string fileName)
        {

            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("\t\tFind Client Screen");
            Console.WriteLine("------------------------------------------------------");

            List<stClient> lClients = LoadClientsDataFromFile(fileName);

            stClient client = new stClient();

            string accountNumber = ReadAccountNumber();

            if (FindClientByAccountNumber(fileName, accountNumber, lClients, ref client))
            {

                PrintClientCard(client);

            }
            else
            {
                Console.WriteLine($"\nClient with Account Number ({accountNumber}) is Not Found!");
            }

        }

        static void ShowEndScreen()
        {

            Console.WriteLine("\n------------------------------------------------------");
            Console.WriteLine("\t\tProgram Ends :-)");
            Console.WriteLine("------------------------------------------------------");

        }

        static short ReadMainMenuOption()
        {

            short choice = 0;

            do
            {

                Console.Write("Choose What You Want to Do? [1 to 7]? ");
                choice = short.Parse(Console.ReadLine());

            } while (choice < 1 || choice > 7);

            return choice;

        }

        static void GoBackToMainMenu(string fileName)
        {

            Console.Write("\nPress any key to go back to Main Menu...");
            Console.ReadKey();

            ShowMainMenuScreen(fileName);

        }

        enum enTransactionsMenuOption { eDeposite = 1, eWithdraw = 2, eTotalBalances = 3, eMainMenu = 4 }

        static short ReadTransactionsMenuOption()
        {

            short choice = 0;

            do
            {

                Console.Write("Choose What You Want to Do? [1 to 4]? ");
                choice = short.Parse(Console.ReadLine());

            } while (choice < 1 || choice > 4);

            return choice;

        }

        static void DepositeBalanceToClientByAccountNumber(string fileName, string accountNumber, double amount, ref List<stClient> lClients)
        {

            char confirm = 'N';

            Console.Write("\nAre you sure you want perform this transaction? Y/N? ");
            confirm = char.Parse(Console.ReadLine());

            if (char.ToUpper(confirm) == 'Y')
            {

                for (int i = 0; i < lClients.Count; i++)
                {

                    if (lClients[i].accountNumber == accountNumber)
                    {

                        stClient c = lClients[i];

                        c.accountBalance += amount;

                        lClients[i] = c;

                        SaveClientsListToFile(fileName, lClients);

                        Console.WriteLine("\n\n Done Successfully. New Balance is: " + lClients[i].accountBalance);

                        break;

                    }

                }

            }

        }

        static void ShowDepositeScreen(string fileName)
        {

            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("\t\tDeposite Screen");
            Console.WriteLine("---------------------------------------------------------");

            List<stClient> lClients = LoadClientsDataFromFile(fileName);

            stClient client = new stClient();

            string accountNumber = ReadAccountNumber();

            while (!FindClientByAccountNumber(fileName, accountNumber, lClients, ref client))
            {

                Console.WriteLine($"Client with [{accountNumber}] doesn't exists.");
                accountNumber = ReadAccountNumber();

            }

            PrintClientCard(client);

            double amount = 0;

            Console.Write("\nPlease enter deposite amount? ");
            amount = double.Parse(Console.ReadLine());

            DepositeBalanceToClientByAccountNumber(fileName, accountNumber, amount, ref lClients);

        }

        static void GoBackToTransactionsMenu(string fileName)
        {

            Console.Write("\nPress any key to go Back to Transactions Menu...");
            Console.ReadKey();

            ShowTransactionsMenuScreen(fileName);

        }

        static void ShowWithdrawScreen(string fileName)
        {

            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("\t\tWithdraw Screen");
            Console.WriteLine("---------------------------------------------------------");

            List<stClient> lClients = LoadClientsDataFromFile(fileName);

            stClient client = new stClient();

            string accountNumber = ReadAccountNumber();

            while (!FindClientByAccountNumber(fileName, accountNumber, lClients, ref client))
            {

                Console.WriteLine($"Client with [{accountNumber}] doesn't exists.");
                accountNumber = ReadAccountNumber();

            }

            PrintClientCard(client);

            double amount = 0;

            Console.Write("\nPlease enter Withdraw Amount? ");
            amount = double.Parse(Console.ReadLine());

            //Validate that the amount does not exceeds the balance
            while (amount > client.accountBalance)
            {

                Console.WriteLine("\nAmount Exceeds the balance, you can withdraw up to " + client.accountBalance);
                Console.Write("Please enter another amount? ");
                amount = double.Parse(Console.ReadLine());

            }

            DepositeBalanceToClientByAccountNumber(fileName, accountNumber, amount * -1, ref lClients);

        }

        static void PrintClientRecordBalanceLine(stClient client)
        {

            Console.Write($"| {client.accountNumber.PadRight(14)}");
            Console.Write($"| {client.name.PadRight(40)}");
            Console.Write($"| {client.accountBalance.ToString().PadRight(14)}");

        }

        static void ShowTotalBalancesScreen(string fileName)
        {

            List<stClient> lClients = LoadClientsDataFromFile(fileName);

            Console.WriteLine($"\n\t\t\t\tBalances List ({lClients.Count}) Client(s).");

            Console.WriteLine("______________________________________________________________________________________________________________\n");

            Console.Write($"| {"Acount Number".PadRight(14)}");
            Console.Write($"| {"Client Name".PadRight(40)}");
            Console.Write($"| {"Balances".PadRight(14)}");

            Console.WriteLine("\n______________________________________________________________________________________________________________\n");

            double totalBalance = 0;

            if (lClients.Count == 0)
            {
                Console.WriteLine("\n No Clients Available In The System!");
            }
            else
            {

                foreach (stClient client in lClients)
                {

                    PrintClientRecordBalanceLine(client);

                    Console.WriteLine();

                    totalBalance += client.accountBalance;

                }

            }

            Console.WriteLine("\n______________________________________________________________________________________________________________");

            Console.WriteLine("\n\t\t\t\tTotal Balances = " + totalBalance.ToString());

        }

        static void PerformTransactionsMenuOption(string fileName, enTransactionsMenuOption transactionsMenuOption)
        {

            switch (transactionsMenuOption)
            {

                case enTransactionsMenuOption.eDeposite:
                    Console.Clear();
                    ShowDepositeScreen(fileName);
                    GoBackToTransactionsMenu(fileName);
                    break;

                case enTransactionsMenuOption.eWithdraw:
                    Console.Clear();
                    ShowWithdrawScreen(fileName);
                    GoBackToTransactionsMenu(fileName);
                    break;

                case enTransactionsMenuOption.eTotalBalances:
                    Console.Clear();
                    ShowTotalBalancesScreen(fileName);
                    GoBackToTransactionsMenu(fileName);
                    break;

                case enTransactionsMenuOption.eMainMenu:
                    ShowMainMenuScreen(fileName);
                    break;

            }

        }

        static void ShowTransactionsMenuScreen(string fileName)
        {

            Console.Clear();

            Console.WriteLine("============================================================");
            Console.WriteLine("\t\t\tTransactions Menu Screen");
            Console.WriteLine("============================================================");

            Console.WriteLine("\t\t[1] Deposite.");
            Console.WriteLine("\t\t[2] Withdraw.");
            Console.WriteLine("\t\t[3] Total Balances.");
            Console.WriteLine("\t\t[4] Main Menu.");

            PerformTransactionsMenuOption(fileName, (enTransactionsMenuOption)ReadTransactionsMenuOption());

        }

        static void PerfromMainMenuOption(string fileName, enMainMenuOptions mainMenuOption)
        {

            switch (mainMenuOption)
            {

                case enMainMenuOptions.eListClients:
                    Console.Clear();
                    ShowClientList(fileName);
                    GoBackToMainMenu(fileName);
                    break;

                case enMainMenuOptions.eAddNewClient:
                    Console.Clear();
                    ShowAddNewClientsScreen(fileName);
                    GoBackToMainMenu(fileName);
                    break;

                case enMainMenuOptions.eDeleteClient:
                    Console.Clear();
                    ShowDeleteClientScreen(fileName);
                    GoBackToMainMenu(fileName);
                    break;

                case enMainMenuOptions.eUpdateClient:
                    Console.Clear();
                    ShowUpdateClientScreen(fileName);
                    GoBackToMainMenu(fileName);
                    break;

                case enMainMenuOptions.eFindClient:
                    Console.Clear();
                    ShowFindClientScreen(fileName);
                    GoBackToMainMenu(fileName);
                    break;

                case enMainMenuOptions.eTransactions:
                    Console.Clear();
                    ShowTransactionsMenuScreen(fileName);
                    break;

                case enMainMenuOptions.eExit:
                    Console.Clear();
                    ShowEndScreen();
                    break;

            }

        }

        static void ShowMainMenuScreen(string fileName)
        {

            Console.Clear();

            Console.WriteLine("============================================================");
            Console.WriteLine("\t\t\tMain Menu Screen");
            Console.WriteLine("============================================================");

            Console.WriteLine("\t\t[1] Show Client List.");
            Console.WriteLine("\t\t[2] Add New Client.");
            Console.WriteLine("\t\t[3] Delete Client.");
            Console.WriteLine("\t\t[4] Update Client Info.");
            Console.WriteLine("\t\t[5] Find Client.");
            Console.WriteLine("\t\t[6] Transactions.");
            Console.WriteLine("\t\t[7] Exit.");

            Console.WriteLine("============================================================");

            PerfromMainMenuOption(fileName, (enMainMenuOptions)ReadMainMenuOption());

        }

        static void Main(string[] args)
        {

            string fileName = "Clients.txt";

            ShowMainMenuScreen(fileName);
            Console.ReadKey();

        }

    }
}
