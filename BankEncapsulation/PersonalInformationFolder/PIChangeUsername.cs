using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.PersonalInformation
{
    internal class PIChangeUsername
    {
        public static void GoToChangeUsername(BankAccount.BankAccount account, CreditCard.CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Change Username Screen\n\n");

            string oldUserName = HardCodedUserInfoClass.GetUserName();
            string entry = "";

            Console.WriteLine("Please enter your old username:\n\n");
            entry = Console.ReadLine();
            Console.WriteLine();

            while (entry != oldUserName)
            {
                Console.WriteLine("Invalid Entry. Please try again.\n");
                entry = Console.ReadLine();
            }

            Console.WriteLine($"\nPlease enter your new username.\n\n");
            string username1 = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine($"\nPlease enter your new username again.\n\n");
            string username2 = Console.ReadLine();
            Console.WriteLine();

            while (username1 != username2)
            {
                Console.WriteLine("\nUsername entries did not match. Try Again.\n\n");
                Console.WriteLine($"\nPlease enter your new username.\n\n");
                username1 = Console.ReadLine();
                Console.WriteLine();

                Console.WriteLine($"\nPlease enter your new username again.\n\n");
                username2 = Console.ReadLine();
                Console.WriteLine();
            }

            HardCodedUserInfoClass.SetUserName(username1);

            Console.WriteLine("\n*****************************************************************************\n\n");
            Console.WriteLine("Username changed successfully. \n\n");

            MainOrExit.GoToMainOrExit(account, card, loan);
        }
    }
}
