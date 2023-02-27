using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.CreditCard
{
    internal class CCAvailableCredit
    {
        public static void GoToCheckAvaialbleCredit(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Check Available Credit Screen\n\n");

            double myAvailableCredit = card.CCCheckAvailableCredit();

            Console.WriteLine($"Current Avaialble Credit: ${myAvailableCredit}");

            MainOrExit.GoToMainOrExit(account, card, loan);
        }
    }
}
