using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.CreditCard
{
    internal class CCTransactionHistoryAll
    {
        public static void GoToTransactionHistoryAll(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("View Transaction History - All\n\n");

            card.CCCheckTransactionHistory(account, card, loan);
        }
    }
}
