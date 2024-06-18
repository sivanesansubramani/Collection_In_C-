using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionObject
{
    class ReciptNo_Calculations
    {
        internal void NextReceiptCalculations()
        {
            List<string> receipts = new List<string> { "S-121-001", "S-121-002", "S-121-003" };
            if (receipts == null || receipts.Count == 0)
            {
                throw new ArgumentException("Receipt collection cannot be null or empty.");
            }

            string latestReceipt = receipts[receipts.Count - 1];

            string[] parts = latestReceipt.Split('-');
            if (parts.Length != 3 || !int.TryParse(parts[2], out int currentNumber))
            {
                throw new FormatException("Receipt number format is invalid.");
            }

            int nextNumber = currentNumber + 1;

            string nextReceipt = $"{parts[0]}-{parts[1]}-{nextNumber:D3}";

            //to check receipt already contains in collection object
            if (receipts.Contains(nextReceipt))
            {
                Console.WriteLine("This receipt no already contains");
            }
            else
            {
                //add a receipt to collection iobject
                receipts.Add(nextReceipt);
            }

            //To Show Collection Object Count
            Console.WriteLine($"Total Recipt Count  "+ receipts.Count);

            //Print all receipts with join inbuild functions
            Console.WriteLine($"All Receipts  " + string.Join(",", receipts));

            Console.WriteLine("New receipt  " + nextReceipt);
            Console.ReadLine();
        }
    }
}
