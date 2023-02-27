using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.CreditCard
{
    internal class CreditCardMainScreen
    {
        public static void GoToCreditCardMainScreen(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Credit Card Main Screen\n\n");
            int loopStart = 14;
            int loopEnd = 20;
            int optionChosen = ScreenSelect.SelectScreen(loopStart, loopEnd);
            if (optionChosen == 14)
            {
                CCAvailableCredit.GoToCheckAvaialbleCredit(account, card, loan);
            }
            else if (optionChosen == 15)
            {
                CCCurrentBalance.GoToCheckCurrentBalance(account,card, loan);
            }
            else if (optionChosen == 16)
            {
                CCMakePurchaseClass.GoToMakePurchase(account, card, loan);
            }
            else if (optionChosen == 17)
            {
                CCMakePaymentClass.GoToMakePayment(account, card, loan);
            }
            else if (optionChosen == 18)
            {
                CreditCardTransHistorySubScreen.GoToTransHistorySubScreen(account, card, loan);
            }
            else if (optionChosen == 19)
            {
                CCCheckCreditLimit.GoToCheckCreditLimit(account, card, loan);
            }
            else if (optionChosen == 20)
            {
                CCChangeCreditLimit.GoToChangeCreditLimit(account, card, loan);
            }
            else
            {
                Console.WriteLine("Error: this should never happen. Options should be between 14 - 20.");
            }
        }
    }
}
