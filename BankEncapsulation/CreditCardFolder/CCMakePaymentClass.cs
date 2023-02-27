using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.CreditCard
{
    internal class CCMakePaymentClass
    {
        public static void GoToMakePayment(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Make Payment Screen\n\n");

            double myPayment = ValidInputAmount.AmountValidEntry("payment");
            Console.WriteLine();

            card.CCMakePayment(myPayment, account, card, loan);
        }
    }
}
