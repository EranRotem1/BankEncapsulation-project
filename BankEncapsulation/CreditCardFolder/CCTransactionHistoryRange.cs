using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.CreditCard
{
    internal class CCTransactionHistoryRange
    {
        public static void GoToTransactionHistoryRange(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("View Transaction History - Range\n\n");

            card.CCCheckHistoryRange(account, card, loan);
        }
    }
}
