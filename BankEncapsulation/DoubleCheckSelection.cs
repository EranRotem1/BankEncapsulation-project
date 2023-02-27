using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class DoubleCheckSelection
    {
        public static string DoubleCheckYesNo()
        {
            Console.WriteLine("\nPlease enter 'Y' for Yes or 'N' for No.\n");
            string yesNo = Console.ReadLine().ToUpper();
            Console.WriteLine();
            while (yesNo != "Y" && yesNo != "N")
            {
                Console.WriteLine("\nInvalid Entry: Please enter 'Y' or 'N'\n");
                yesNo = Console.ReadLine().ToUpper();
                Console.WriteLine();
                if (yesNo == "Y" || yesNo == "N")
                {
                    break;
                }
            }
            return yesNo;
        }
    }
}
