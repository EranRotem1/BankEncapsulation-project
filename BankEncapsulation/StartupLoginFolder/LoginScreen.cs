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
            Console.WriteLine("Login Screen\n\nEnter your username or \"BACK\" to go back to the Start-Up Screen:\n\n");
            string tempUser = Console.ReadLine();
            string realUserName = HardCodedUserInfoClass.GetUserName();
            while (tempUser != realUserName)
            {
                if(tempUser == "BACK")
                {
                    break;
                }
                Console.WriteLine("\nUsername does not exist. Please try Again.\n\nRe-enter your username or \"BACK\" to go back to the Start-Up Screen:\n\n");
                tempUser = Console.ReadLine();
            }
            if(tempUser == "BACK")
            {
                StartUpScreen.GoToStartUpScreen(account, card, loan);
            }
            
            Console.WriteLine("\n\nEnter your password or \"BACK\" to go back to the Start-Up Screen:\n\n");

            string tempPassword = null;
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                tempPassword += key.KeyChar;
                Console.Write("*");
            }
            string realPassword = HardCodedUserInfoClass.GetPassword();
            while (tempPassword != realPassword)
            {
                if (tempPassword == "BACK")
                {
                    break;
                }
                Console.WriteLine("\nIncorrect password entry. Please try Again.\n\nRe-enter your password or \"BACK\" to go back to the Start-Up Screen:\n\n");
                tempPassword = null;
                while (true)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                        break;
                    tempPassword += key.KeyChar;
                    Console.Write("*");
                }
            }
            if (tempPassword == "BACK")
            {
                StartUpScreen.GoToStartUpScreen(account, card, loan);
            }

            Console.WriteLine("****************************************************************************************************\n\n");
            Console.WriteLine("Login Successful.\n\n");
            Console.WriteLine("Press any key to continue to the main screen.\n\n");
            Console.ReadKey();
            MainMenuScreen.GoToMainScreen(account, card, loan);
        }
    }
}
