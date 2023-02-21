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
            Console.WriteLine("Change Password\n");
            string password1 = "1";
            string password2 = "2";

            while (password1 != password2)
            {
                Console.WriteLine("Please enter the new desired username:");
                password1 = Console.ReadLine();
                Console.WriteLine("Please enter the new desired username again:");
                password2 = Console.ReadLine();
                if (password1 != password2)
                {
                    Console.WriteLine("Usernames entered do not match. Try again.");
                }
                else
                {
                    Console.WriteLine("Password entered match.");
                }

            }
            //Code for actually changing password
            MainOrExit.GoToMainOrExit(account, card, loan);
        }
    }
}
