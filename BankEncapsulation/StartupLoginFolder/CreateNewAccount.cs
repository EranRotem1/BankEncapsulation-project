using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.StartupLogin
{
    internal class CreateNewAccount
    {
        public static void GoToCreateNewAccount() //Later Stage Feature: Multiple users
        {
            Console.WriteLine("Create New Account\nEnter your desired Username:");
            
            //Code to check against list of registered Usernames
            Console.WriteLine("Enter your password:");
            //Code to read password as a string
            Console.WriteLine("Enter your password again:");
            //Code to read password as a string

            //Code to make sure passwords match

            //Code to check against list of registered Passwords

            //Code for registered username and associated password matching, allowing them to login
            //Otherwise, back to main screen (just in case they didn't mean to hit login or forgot their password)
        }
    }
}
