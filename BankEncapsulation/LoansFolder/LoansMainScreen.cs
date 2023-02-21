using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.Loans
{
    internal class LoansMainScreen
    {
        public static void GoToLoansMainScreen(BankAccount.BankAccount account, CreditCard.CreditCard card, Loan loan)
        {
            Console.Clear();
            Console.WriteLine("Loans Main Screen\n");
            int loopStart = 21;
            int loopEnd = 24;
            int optionChosen = ScreenSelect.SelectScreen(loopStart, loopEnd);
            if (optionChosen == 21)
            {
                LApplyForLoan.GoToApplyForLoan();
            }
            else if (optionChosen == 22)
            {
                LCheckLoanDetails.GoToCheckLoanDetails(account, card, loan);
            }
            else if (optionChosen == 23)
            {
                LMakeLoanPayment.GoToMakeLoanPayment(account, card, loan);
            }
            else if (optionChosen == 24)
            {
                LCheckLoanPaymentHIstory.GoToCheckLoanPaymentHistory(account, card,loan);
            }
            else
            {
                Console.WriteLine("Error: this should never happen. Options should be between 21 - 24.");
            }
        }
    }
}
