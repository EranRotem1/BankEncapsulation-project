using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.CreditCard
{
    internal class CCMakePurchaseClass
    {
        public static void GoToMakePurchase(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Make Purchase Screen\n\n");

            double myPurchase = ValidInputAmount.AmountValidEntry("purchase");

            card.CCMakePurchase(myPurchase, account, card, loan);
        }
    }
}
