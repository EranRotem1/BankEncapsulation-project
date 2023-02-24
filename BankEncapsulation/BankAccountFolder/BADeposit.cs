using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.BankAccount
{
    internal class BADeposit
    {
        public static void GoToBankAccountDeposit(BankAccount account, CreditCard.CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Bank Account Deposit");
            Console.WriteLine("How much would you like to deposit?");
            double amount = double.Parse(Console.ReadLine());
            //Code for reading in and validating deposit (type double)
            //Code for double checking input is correct
            account.Deposit(amount);
            BACheckBalance.GoToBankAccountBalance(account, card, loan);
            //Code to either return to main screen or log off.

        }
    }
}
