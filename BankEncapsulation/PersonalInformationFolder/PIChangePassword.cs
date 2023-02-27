using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.PersonalInformation
{
    internal class PIChangePassword
    {
        public static void GoToChangePassword(BankAccount.BankAccount account, CreditCard.CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Change Password Screen\n\n");

            string oldPass = HardCodedUserInfoClass.GetPassword();
            string entry = null;

            Console.WriteLine("\n\nPlease enter your old password:\n\n");
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                entry += key.KeyChar;
                Console.Write("*");
            }
            Console.WriteLine();
            while (entry != oldPass)
            {
                entry = null;
                Console.WriteLine("\n\nInvalid Entry. Please try again.\n\n");
                while (true)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                        break;
                    entry += key.KeyChar;
                    Console.Write("*");
                }
            }
            Console.WriteLine();

            Console.WriteLine($"\nPlease enter your new password.\n\n");
            string password1 = null;
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                password1 += key.KeyChar;
                Console.Write("*");
            }
            Console.WriteLine();

            Console.WriteLine($"Please enter your new password again.\n\n");
            string password2 = null;
            while (true)
            {
                var key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.Enter)
                    break;
                password2 += key.KeyChar;
                Console.Write("*");
            }
            Console.WriteLine();

            while (password1 != password2)
            {
                Console.WriteLine("\n\nPassword entries did not match. Try Again.\n\n");
                Console.WriteLine($"Please enter your new password. Hit \"Enter\" when finished.\n\n");
                password1 = null;
                while (true)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                        break;
                    password1 += key.KeyChar;
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.WriteLine($"Please enter your new password again. Hit \"Enter\" when finished.\n\n");
                password2 = null;
                while (true)
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Enter)
                        break;
                    password2 += key.KeyChar;
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            HardCodedUserInfoClass.SetPassword(password1);
            Console.WriteLine("\n*****************************************************************************\n\n");
            Console.WriteLine("Password changed successfully. \n\n");

            MainOrExit.GoToMainOrExit(account, card, loan);
        }
    }
}
