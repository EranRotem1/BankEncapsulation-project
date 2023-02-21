using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.StartupLogin
{
    internal class LoginScreen
    {
        public static void GoToLoginScreen(BankAccount.BankAccount account, CreditCard.CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Login Screen\n\nEnter your username or \"BACK\" to go back to the Start-Up Screen:\n");
            string tempUser = Console.ReadLine();
            HardCodedUserInfoClass instance = new HardCodedUserInfoClass();
            string realUserName = instance.GetUserName();
            while (tempUser != realUserName)
            {
                if(tempUser == "BACK")
                {
                    break;
                }
                Console.WriteLine("\nUsername does not exist. Please try Again.\n Re-enter your username or \"BACK\" to go back to the Start-Up Screen:\n");
                tempUser = Console.ReadLine();
            }
            if(tempUser == "BACK")
            {
                StartUpScreen.GoToStartUpScreen(account, card, loan);
            }
            
            Console.WriteLine("\nEnter your password or \"BACK\" to go back to the Start-Up Screen:\n");
            string tempPassword = Console.ReadLine();
            string realPassword = instance.GetPassword();
            while (tempPassword != realPassword)
            {
                if (tempPassword == "BACK")
                {
                    break;
                }
                Console.WriteLine("\nIncorrect password entry. Please try Again.\n Re-enter your password or \"BACK\" to go back to the Start-Up Screen:\n");
                tempPassword = Console.ReadLine();
            }
            if (tempPassword == "BACK")
            {
                StartUpScreen.GoToStartUpScreen(account, card, loan);
            }

            Console.WriteLine("\n****************************************************************************************************");
            Console.WriteLine("\nLogin Successful.");
            Console.WriteLine("\nPress any key to continue to the main screen.\n");
            Console.ReadKey();
            MainMenuScreen.GoToMainScreen(account, card, loan);

            //Otherwise, back to main screen (just in case they didn't mean to hit login or forgot their password)
        }
    }
}
