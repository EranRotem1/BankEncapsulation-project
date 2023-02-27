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
            Console.WriteLine("Change Annual Salary Screen\n\n");
            string answer = "N";
            while (answer == "N")
            {
                double salary = ValidInputAmount.AmountValidEntry("new annual salary");

                Console.WriteLine($"\nIs your entry of ${salary} correct?\n\n");
                answer = DoubleCheckSelection.DoubleCheckYesNo();

                if (answer == "Y")
                {
                    HardCodedUserInfoClass.SetAnnualIncome(salary);
                    Console.WriteLine("\n*****************************************************************************\n\n");
                    Console.WriteLine("Annual salary changed successfully. \n\n");
                    break;
                }
            }
            MainOrExit.GoToMainOrExit(account, card, loan);
        }
    }
}
