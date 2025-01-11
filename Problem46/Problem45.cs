using System.Runtime.InteropServices;

namespace Problem45
{
    // Convert Record To Line
    internal class Problem45
    {

        struct stClientData
        {

            public string accNumber;
            public string pinCode;
            public string name;
            public string phone;
            public double accBalance;

        }

        static stClientData ReadNewClient()
        {

            stClientData clientData = new stClientData();

            Console.WriteLine("Please enter client Data:\n");

            Console.Write("Enter Account Number? ");
            clientData.accNumber = Console.ReadLine();

            Console.Write("Enter Pin Code? ");
            clientData.pinCode = Console.ReadLine();

            Console.Write("Enter Name? ");
            clientData.name = Console.ReadLine();

            Console.Write("Enter Phone? ");
            clientData.phone = Console.ReadLine();

            Console.Write("Enter Account Balance? ");
            clientData.accBalance = double.Parse(Console.ReadLine());

            return clientData;

        }

        static string ConvertRecordToLine(stClientData clientData, string separator = "#//#")
        {

            string clientRecord = "";

            clientRecord += clientData.accNumber + separator;
            clientRecord += clientData.pinCode + separator;
            clientRecord += clientData.name + separator;
            clientRecord += clientData.phone + separator;
            clientRecord += clientData.accBalance.ToString();

            return clientRecord;

        }

        static void Main(string[] args)
        {

            stClientData client;
            client = ReadNewClient();

            Console.WriteLine("\n\nClient Record for saving is:");
            Console.WriteLine(ConvertRecordToLine(client));

        }
    }
}