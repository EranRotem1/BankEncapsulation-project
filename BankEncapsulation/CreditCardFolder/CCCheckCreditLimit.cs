using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.CreditCard
{
    internal class CCCheckCreditLimit
    {
        public static void GoToCheckCreditLimit(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Check Credit Limit Screen\n\n");

            double myCreditLimit = card.CCCheckCreditLimit();

            Console.WriteLine($"Your Credit Limit: ${myCreditLimit}");

            MainOrExit.GoToMainOrExit(account, card, loan);
        }
    }
}
