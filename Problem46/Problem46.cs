namespace Problem46
{
    // Convert Line Data To Record
    internal class Problem46
    {

        struct stClientData
        {
            public string accountNumber;
            public string pinCode;
            public string name;
            public string phone;
            public double accountBalance;
        }

        static List<string> SplitString(string text, string separator)
        {

            List<string> lString = new List<string>();

            string sWord = "";
            short pos = 0;

            while ((pos = (short)text.IndexOf(separator)) != -1)
            {

                sWord = text.Substring(0, pos);

                if (sWord != "")
                {
                    lString.Add(sWord);
                }

                text = text.Substring(pos + separator.Length);

            }

            if (text != "")
            {
                lString.Add(text);
            }

            return lString;

        }

        static stClientData ConvertLineDataToRecord(string lineData, string separator = "#//#")
        {

            stClientData clientData;

            List<string> lRecord = SplitString(lineData, separator);

            clientData.accountNumber = lRecord[0];
            clientData.pinCode = lRecord[1];
            clientData.name = lRecord[2];
            clientData.phone = lRecord[3];
            clientData.accountBalance = double.Parse(lRecord[4]);

            return clientData;

        }

        static void PrintClientRecord(stClientData clientData)
        {

            Console.WriteLine("\nThe following is the extracted client record :\n");

            Console.WriteLine("Account Number: " + clientData.accountNumber);
            Console.WriteLine("Pin Code: " + clientData.pinCode);
            Console.WriteLine("Name: " + clientData.name);
            Console.WriteLine("Phone: " + clientData.phone);
            Console.WriteLine("Account Balance: " + clientData.accountBalance);

        }

        static void Main(string[] args)
        {

            string lineData = "A150#//#1234#//#Abdelrahman Medhat#//#079999#//#5270.100000";

            Console.WriteLine("\nLine Record is:\n" + lineData);

            stClientData client = ConvertLineDataToRecord(lineData);

            PrintClientRecord(client);

        }
    }
}