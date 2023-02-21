using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.CreditCard
{
    internal class CreditCardMainScreen
    {
        public static void GoToCreditCardMainScreen(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Credit Card Main Screen\n");
            int loopStart = 14;
            int loopEnd = 20;
            int optionChosen = ScreenSelect.SelectScreen(loopStart, loopEnd);
            if (optionChosen == 14)
            {

            }
            else if (optionChosen == 15)
            {

            }
            else if (optionChosen == 16)
            {

            }
            else if (optionChosen != 17)
            {

            }
            else if (optionChosen != 18)
            {

            }
            else if (optionChosen != 19)
            {

            }
            else if (optionChosen != 20)
            {

            }
            else
            {
                Console.WriteLine("Error: this should never happen. Options should be between 14 - 20.");
            }
        }
    }
}
