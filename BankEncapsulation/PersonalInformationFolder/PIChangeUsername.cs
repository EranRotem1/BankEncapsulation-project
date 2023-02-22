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
            Console.WriteLine("Change Username\n");
            string username1 = "1";
            string username2 = "2";
            bool usernameTaken = false;

            while (username1 != username2 || usernameTaken == true)
            {
                usernameTaken = false;
                Console.WriteLine("Please enter the new desired username:");
                username1 = Console.ReadLine();
                Console.WriteLine("Please enter the new desired username again:");
                username2 = Console.ReadLine();
                if (username1 != username2)
                {
                    Console.WriteLine("Usernames entered do not match. Try again.");
                }
                else
                {
                    for (int i = 0; i < 10;i++) //Code to check if username is already taken. 10 will be replaced with registered username list name length
                    {
                        if (username1 == "")
                        {
                            usernameTaken = true;
                            break;
                        }
                    }
                }

            }
            //Code for actually changing username
            MainOrExit.GoToMainOrExit(account, card, loan);
        }
    }
}
