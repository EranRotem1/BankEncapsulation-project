using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.BankAccount
{
    internal class BankAccountMainScreen
    {
        public static void GoToBankAccountMainScreen(BankAccount account, CreditCard.CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Bank Account Main\n");
            int loopStart = 25;
            int loopEnd = 27;
            int optionChosen = ScreenSelect.SelectScreen(loopStart, loopEnd);
            if (optionChosen == 25)
            {
                BADeposit.GoToBankAccountDeposit(account, card, loan);
            }
            else if (optionChosen == 26)
            {
                BACheckBalance.GoToBankAccountBalance(account, card, loan);
            }
            else if (optionChosen == 27)
            {
                BAWithdrawal.GoToBankAccountWithdrawal(account, card, loan);
            }
            else
            {
                Console.WriteLine("Error: this should never happen. Options should be between 25 - 27.");
            }
        }
    }
}
