using BankEncapsulation.CreditCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.CreditCard
{
    internal class CreditCardTransHistorySubScreen
    {
        public static void GoToTransHistorySubScreen(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Transaction History Sub-Screen\n\n");
            int loopStart = 31;
            int loopEnd = 33;
            int optionChosen = ScreenSelect.SelectScreen(loopStart, loopEnd);
            if (optionChosen == 31)
            {
                CCTransactionHistoryAll.GoToTransactionHistoryAll(account, card, loan);
            }
            else if (optionChosen == 32)
            {
                CCTransactionHistoryLastStatement.GoToTransactionHistoryLastStatment(account, card, loan);
            }
            else if (optionChosen == 33)
            {
                CCTransactionHistoryRange.GoToTransactionHistoryRange(account, card, loan);
            }
            else
            {
                Console.WriteLine("Error: this should never happen. Options should be between 31 - 33.");
            }
        }
    }
}
