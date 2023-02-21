using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.PersonalInformation
{
    internal class PIChangeAnnualSalary
    {
        public static void GoToChangeAnnualSalary(BankAccount.BankAccount account, CreditCard.CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Change Annual Salary\n");

            Console.WriteLine("Please enter the new annual salary (digits only):");
            //Code for reading in and validating deposit (type double)
            //Code for double checking input is correct
            //Code for (object).Deposit
            MainOrExit.GoToMainOrExit(account, card, loan);
        }
    }
}
