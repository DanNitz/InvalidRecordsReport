using System;
namespace InvalidRecordsReport
{

    public class ReadFile
    {
        //writing my methods to test each 'field' for their requirements since each field has different requirements
        //when it comes to data type, length, format and is required.
        private static void ValidateRecordNumber(string recordNumber, string accountNumber)
        {
            int parsedRecordNumber;

            bool success = int.TryParse(recordNumber, out parsedRecordNumber);

            if(String.IsNullOrWhiteSpace(recordNumber))

            {
                Console.WriteLine($"INVALID FIELD: Record Number: '{recordNumber}' | Record Number cannot be blank = '{recordNumber}' | Account Number = '{accountNumber}'");
            }

            else if (!success)
            {
                Console.WriteLine($"INVALID FIELD - Record Number: '{recordNumber}' | Record Number must be an integer");
            }

        }

        private static void ValidateAccountNumber(string recordNumber, string accountNumber)
        {
            if (String.IsNullOrWhiteSpace(accountNumber))
            {
                Console.WriteLine($"INVALID FIELD: Record Number: {recordNumber} | Account Number cannot be blank = '{accountNumber}'");
            }

            else if (accountNumber.Length != 10)
            {
                Console.WriteLine($"INVALID FIELD: Record Number: '{recordNumber}' | Account Number must be 10 characters long = '{accountNumber}' ");
            }
        }

        private static void ValidateFirstName(string recordNumber, string firstName)
        {

            if (String.IsNullOrWhiteSpace(firstName))

            {
                Console.WriteLine($"INVALID FIELD: Record Number: '{recordNumber}' | First name cannot be blank = '{firstName}'");
            }

        }

        private static void ValidateLastName(string recordNumber, string lastName)
        {
            if (String.IsNullOrWhiteSpace(lastName))

            {
                Console.WriteLine($"INVALID FIELD: Record Number: '{recordNumber}' | Last name cannot be blank = '{lastName}'");
            }

        }

        private static void ValidateAddressLine1(string recordNumber, string addressLine1)
        {
            if (String.IsNullOrWhiteSpace(addressLine1))

            {
                Console.WriteLine($"INVALID FIELD: Record Number: '{recordNumber}' | Address Line 1 cannot be blank = '{addressLine1}'");
            }
        }

        private static void ValidateAddressLine2(string recordNumber, string addressLine2)
        {
            //dont need this test since it is not required
            //if (String.IsNullOrWhiteSpace(addressLine2))

            //{
            //    Console.WriteLine($"INVALID FIELD: Record Number: '{recordNumber}' | Invalid Address Line 2 = '{addressLine2}'");
            //}
        }

        private static void ValidateCity(string recordNumber, string city)
        {
            if (String.IsNullOrWhiteSpace(city))

            {
                Console.WriteLine($"INVALID FIELD: Record Number: '{recordNumber}' | City cannot be blank = '{city}'");
            }
        }

        private static void ValidateState(string recordNumber, string state)
        {
            if (String.IsNullOrWhiteSpace(state))

            {
                Console.WriteLine($"INVALID FIELD: Record Number: '{recordNumber}' | State cannot be blank= '{state}'");
            }
        }

        private static void ValidateAmount(string recordNumber, string amount)
        {
            double parsedAmount;

            bool success = double.TryParse(amount, out parsedAmount);

            if (String.IsNullOrWhiteSpace(amount))

            {
                Console.WriteLine($"INVALID FIELD: Record Number: '{recordNumber}' | Amount cannot be blank = '{amount}'");
            }

            else if (!success)
            {
                Console.WriteLine($"INVALID FIELD: Record Number: '{recordNumber}' | Amount must be a number = '{amount}'");
            }
        }

        public static void ReadSampleFile()
        {
            string path = @"../../../SampleFile.txt";

            // string fileName = "SampleFile.txt";
            //  \n - for new line  \t - for tab indent

            // read each line of the file into a string array - each element of this array is one line of the file
            string[] data = File.ReadAllLines(path); //parameter is my filepath

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("INVALID RECORDS FOUND BELOW");
            Console.ForegroundColor = ConsoleColor.White;

            // Use a foreach loop to define substrings
            foreach (string line in data)

            {

                string recordNumber = line.Substring(0, 4).Trim();
                string accountNumber = line.Substring(4, 10).Trim();
                string firstName = line.Substring(14, 20).Trim();
                string lastName = line.Substring(34, 20).Trim();
                string addressLine1 = line.Substring(54, 30).Trim();
                string addressLine2 = line.Substring(84, 30).Trim();
                string city = line.Substring(114, 20).Trim();
                string state = line.Substring(134, 2).Trim();
                string amount = line.Substring(136, 7).Trim();


                //I used this below to help me see the data in the console as a visual aid for my variables/output when starting the project
                //Console.WriteLine(recordNumber + " " + accountNumber + " " + firstName + " " + lastName + " " + addressLine1 + " " + addressLine2
                //    + " " + city + " " + state + " " + amount + "\n");

                //calling my methods to show invalid records and invalid field value
                ValidateRecordNumber(recordNumber, accountNumber);
                ValidateAccountNumber(recordNumber, accountNumber);
                ValidateFirstName(recordNumber, firstName);
                ValidateLastName(recordNumber, lastName);
                ValidateAddressLine1(recordNumber, addressLine1);
                ValidateAddressLine2(recordNumber, addressLine2);
                ValidateCity(recordNumber, city);
                ValidateState(recordNumber, state);
                ValidateAmount(recordNumber, amount);


            }

            // where my data lives and accessing it (also again a visual aid reference for myself)
            //Console.WriteLine($"index 6 in 1st line of data {data[0][6]}");

        }

       
    }
}

