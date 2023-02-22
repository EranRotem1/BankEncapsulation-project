using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.PersonalInformation
{
    internal class PersonalInfoMainScreen
    {
        public static void GoToPersonalInformationMainScreen(BankAccount.BankAccount account, CreditCard.CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Personal Information Main Screen \n");
            int loopStart = 28;
            int loopEnd = 30;
            int optionChosen = ScreenSelect.SelectScreen(loopStart, loopEnd);
            if (optionChosen == 28)
            {
                PIChangeAnnualSalary.GoToChangeAnnualSalary(account, card, loan);
            }
            else if (optionChosen == 29)
            {
                PIChangeUsername.GoToChangeUsername(account, card, loan);
            }
            else if (optionChosen == 30)
            {
                PIChangePassword.GoToChangePassword(account, card, loan);
            }
            else
            {
                Console.WriteLine("Error: this should never happen. Options should be between 28 - 30.");
            }
        }
    }
}
