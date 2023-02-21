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
            Console.WriteLine("Please enter 'Y' for Yes or 'N' for No.");
            string yesNo = Console.ReadLine().ToUpper();

            while (yesNo != "Y" && yesNo != "N")
            {
                Console.WriteLine("Invalid Entry: Please enter 'Y' or 'N'");
                yesNo = Console.ReadLine().ToUpper();
                if (yesNo == "Y" || yesNo == "N")
                {
                    break;
                }
            }
            return yesNo;
        }
    }
}
