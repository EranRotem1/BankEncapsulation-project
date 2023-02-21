using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class ValidInputDates
    {
        public static DateTime SelectDate(string startEnd)
        {
            Console.WriteLine($"Please enter the {startEnd} date of the range in the format (DD.MM.YYYY)");
            DateTime verifiedDate; //Creates variable of data type "DataTime" named "startDate"
            string strDate = Console.ReadLine();
            while (!DateTime.TryParseExact(strDate, "dd'.'MM'.'yyyy",
                    CultureInfo.CurrentCulture, DateTimeStyles.None, out verifiedDate))
            {
                Console.WriteLine("Invalid Entry: Please enter valid date with format:\"DD.MM.YYYY\"");
                strDate = Console.ReadLine();
            }
            return verifiedDate;
        }
    }
}
