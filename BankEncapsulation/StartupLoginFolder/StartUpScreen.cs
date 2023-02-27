using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.StartupLogin
{
    internal class StartUpScreen
    {
        public static void GoToStartUpScreen(BankAccount.BankAccount account, CreditCard.CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Start-Up Screen\n\n");
            int loopStart = 11;
            int loopEnd = 13;
            int optionChosen = ScreenSelect.SelectScreen(loopStart, loopEnd);
            if (optionChosen == 11)
            {
                LoginScreen.GoToLoginScreen(account, card, loan);
            }
            else if (optionChosen == 12)
            {
                ForgotPassword.GoToForgotPassword(account, card, loan);
            }
            else if (optionChosen == 13) //Not going to build this out for now
            {
                Console.Clear();
                Console.WriteLine("Create New Account Screen\n\n");
                Console.WriteLine("Feature Coming Soon!\n\n");
                Console.WriteLine("Press any key to return to the Start-Up screen.\n\n");
                Console.ReadKey();

                GoToStartUpScreen(account,card,loan);

                //CreateNewAccount.GoToCreateNewAccount();
            }
            else
            { Console.WriteLine("Error: This should never happen. Should be selection 11 - 13"); }
        }
    }
}
