using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.CreditCard
{
    internal class CCCurrentBalance
    {
        public static void GoToCheckCurrentBalance(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Check Current Balance Screen\n\n");

            double myCurrentBalance = card.CCCheckCurrentBalance();

            Console.WriteLine($"Current Balance Owed: ${myCurrentBalance}");

            MainOrExit.GoToMainOrExit(account, card, loan);
        }
    }
}
