using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.CreditCard
{
    internal class CCChangeCreditLimit
    {
        public static void GoToChangeCreditLimit(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Change Credit Limit Screen\n\n");

            double myLimit = ValidInputAmount.AmountValidEntry("new requested credit limit");

            card.CCMakeCredChange(myLimit, account, card, loan);
        }
    }
}
