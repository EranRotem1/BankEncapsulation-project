using BankEncapsulation.CreditCard;
using BankEncapsulation.StartupLogin;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main() //Sets Up initial bank account, credit card account, and loan before Start-Up screen.
        {
            BankAccount.BankAccount EJ_Checking = new BankAccount.BankAccount(10000); //Creates bank account

            EJ_Checking.CreateTestLogIn(100); //Creates fake history of deposits into bank account
            EJ_Checking.CreateTestLogOut(50); //Creates fake history of dwithdrawals into bank account

            //*****************************************************************************************************************

            CreditCard.CreditCard EJ_CreditCard = new CreditCard.CreditCard(5000); //Creates credit card

            EJ_CreditCard.CCCreateTestLogPurchase(100); //Creates fake history of purchases
            EJ_CreditCard.CCCreateTestLogPayment(50); //Creates fake history of payments


            //*****************************************************************************************************************

            Loans.Loan EJ_Loan = new Loans.Loan(3000); //Creates loan for $3000

            EJ_Loan.LCreateTestLogLoanPayment(100); //Creates fake history of loan payments

            //*****************************************************************************************************************

            Console.WriteLine("Set-Up Successful\n\n");
            Console.WriteLine("Press any key to continue to the Start-Up screen.\n\n");
            Console.ReadKey();

            StartUpScreen.GoToStartUpScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);

            MainMenuScreen.GoToMainScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);
            MainOrExit.GoToMainOrExit(EJ_Checking, EJ_CreditCard, EJ_Loan);
            LoginScreen.GoToLoginScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);
            StartUpScreen.GoToStartUpScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);

            PersonalInformation.PersonalInfoMainScreen.GoToPersonalInformationMainScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);
            PersonalInformation.PIChangeAnnualSalary.GoToChangeAnnualSalary(EJ_Checking, EJ_CreditCard, EJ_Loan);
            PersonalInformation.PIChangePassword.GoToChangePassword(EJ_Checking, EJ_CreditCard, EJ_Loan);
            PersonalInformation.PIChangeUsername.GoToChangeUsername(EJ_Checking, EJ_CreditCard, EJ_Loan);

            BankAccount.BankAccountMainScreen.GoToBankAccountMainScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);
            BankAccount.BACheckBalance.GoToBankAccountBalance(EJ_Checking, EJ_CreditCard, EJ_Loan);
            BankAccount.BADeposit.GoToBankAccountDeposit(EJ_Checking, EJ_CreditCard, EJ_Loan);
            BankAccount.BAWithdrawal.GoToBankAccountWithdrawal(EJ_Checking, EJ_CreditCard, EJ_Loan);

            CreditCard.CreditCardMainScreen.GoToCreditCardMainScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);
            CreditCard.CCAvailableCredit.GoToCheckAvaialbleCredit(EJ_Checking, EJ_CreditCard, EJ_Loan);
            CreditCard.CCChangeCreditLimit.GoToChangeCreditLimit(EJ_Checking, EJ_CreditCard, EJ_Loan);
            CreditCard.CCCheckCreditLimit.GoToCheckCreditLimit(EJ_Checking, EJ_CreditCard, EJ_Loan);
            CreditCard.CCCurrentBalance.GoToCheckCurrentBalance(EJ_Checking, EJ_CreditCard, EJ_Loan);
            CreditCard.CCMakePaymentClass.GoToMakePayment(EJ_Checking, EJ_CreditCard, EJ_Loan);
            CreditCard.CCMakePurchaseClass.GoToMakePurchase(EJ_Checking, EJ_CreditCard, EJ_Loan);
            CreditCard.CCTransactionHistoryAll.GoToTransactionHistoryAll(EJ_Checking, EJ_CreditCard, EJ_Loan);
            CreditCard.CCTransactionHistoryLastStatement.GoToTransactionHistoryLastStatment(EJ_Checking, EJ_CreditCard, EJ_Loan);
            CreditCard.CCTransactionHistoryRange.GoToTransactionHistoryRange(EJ_Checking, EJ_CreditCard, EJ_Loan);
            CreditCard.CreditCardTransHistorySubScreen.GoToTransHistorySubScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);

            Loans.LoansMainScreen.GoToLoansMainScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);
            Loans.LCheckLoanDetails.GoToCheckLoanDetails(EJ_Checking, EJ_CreditCard, EJ_Loan);
            Loans.LCheckLoanPaymentHIstory.GoToCheckLoanPaymentHistory(EJ_Checking, EJ_CreditCard, EJ_Loan);
            Loans.LMakeLoanPayment.GoToMakeLoanPayment(EJ_Checking, EJ_CreditCard, EJ_Loan);
        }
    }
}
