using BankEncapsulation;
using BankEncapsulation.StartupLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class MainMenuScreen
    {
        public static void GoToMainScreen(BankAccount.BankAccount account, CreditCard.CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Main Screen\n");
            int loopStart = 1;
            int loopEnd = 5;
            int optionChosen = ScreenSelect.SelectScreen(loopStart, loopEnd);
            if (optionChosen == 1) //Personal Information
            {
                PersonalInformation.PersonalInfoMainScreen.GoToPersonalInformationMainScreen(account, card, loan);
            }
            else if (optionChosen == 2) //Bank Account
            {
                BankAccount.BankAccountMainScreen.GoToBankAccountMainScreen(account, card, loan);
            }
            else if (optionChosen == 3) //Credit Card
            {
                CreditCard.CreditCardMainScreen.GoToCreditCardMainScreen(account, card, loan);
            }
            else if (optionChosen == 4) //Loans
            {
                Loans.LoansMainScreen.GoToLoansMainScreen(account, card, loan);
            }
            else if (optionChosen == 5) //Help
            {
                Console.WriteLine("\n****************************************************************************************************");
                Console.WriteLine("\nPlease contact our technical support team at 800-123-4567");

                MainOrExit.GoToMainOrExit(account, card, loan);
            }
        }
    }
}
