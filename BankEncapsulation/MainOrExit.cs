using BankEncapsulation.StartupLogin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    internal class MainOrExit
    {
        public static void GoToMainOrExit(BankAccount.BankAccount account, CreditCard.CreditCard card, Loans.Loan loan)
        {
            Console.Write("\nEnter \"EXIT\" to logoff or \"MAIN\" to go back to the Main screen:\n\n");

            string entry = Console.ReadLine().ToUpper();

            while (entry != "MAIN" && entry != "EXIT")
            {
                Console.WriteLine("\nInvalid Entry. Enter \"EXIT\" to logoff or \"MAIN\" to go back to the Main screen:\n\n");
                entry = Console.ReadLine().ToUpper();
            }

            if (entry == "EXIT")
            {
                StartUpScreen.GoToStartUpScreen(account, card, loan);
            }
            else if (entry == "MAIN")
            {
                MainMenuScreen.GoToMainScreen(account, card, loan);
            }
            else
            {
                Console.WriteLine("Error. This should never happen. Should only accept MAIN or EXIT.");
            }
        }
    }
}
