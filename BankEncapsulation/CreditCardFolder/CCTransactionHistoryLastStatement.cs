using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.CreditCard
{
    internal class CCTransactionHistoryLastStatement
    {
        public static void GoToTransactionHistoryLastStatment(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("View Transaction History - Last Statment\n\n");

            card.CCCheckLastStatement(account, card, loan);
        }
    }
}
