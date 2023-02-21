using BankEncapsulation.StartupLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.BankAccount
{
    internal static class BACheckBalance
    {
        public static void GoToBankAccountBalance(BankAccount account, CreditCard.CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Bank Account Balance\n\n");

            double myBalance = account.GetBalance();

            Console.WriteLine($"Current Balance: ${myBalance}");

            MainOrExit.GoToMainOrExit(account, card, loan);
        }
    }
}
