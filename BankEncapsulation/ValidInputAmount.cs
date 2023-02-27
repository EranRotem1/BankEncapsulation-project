using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal static class ValidInputAmount
    {
        public static double AmountValidEntry(string type)
        {
            Console.WriteLine($"\nWhat is the amount of your {type}? Please enter only digits.\n");
            double verifiedAmt;
            string strAmt = Console.ReadLine();
            while (!double.TryParse(strAmt,out verifiedAmt))
            {
                Console.WriteLine("\nInvalid Entry: Please enter amount using only digits.\n");
                strAmt = Console.ReadLine();
            }
            return verifiedAmt;
        }
    }
}
