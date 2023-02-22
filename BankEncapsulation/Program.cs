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

<<<<<<< HEAD
        public static void Main(string[] args)
        {
            Console.WriteLine("K&R Banking\n-Input option number:\n1. Personal info\n2. Account info\n3. Credit Cards\n4. Loans\n5. Help");
            switch(ScreenSelect.ValidInput(5))
            {
                case 1: //personal info
                    Console.Clear();
                    Console.WriteLine("1. View Profile\n2. Edit Profile");
                    switch(ScreenSelect.ValidInput(2))
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine();
                            break;

                        case 2:
                            Console.Clear();
                            Console.WriteLine();
                            break;
                    }
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine();
                    break;

                case 3:
                    Console.Clear();
                    
                    Console.WriteLine();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine();
                    break;

            }
            //ScreenSelect.SelectScreen();
            //BankAccount Erans_Checking = new BankAccount();           
            //Erans_Checking.Deposit(2500);
            //Console.WriteLine(Erans_Checking.GetBalance());
            //Erans_Checking.Withdraw(500);
            //Console.WriteLine(Erans_Checking.GetBalance());
=======
            Console.WriteLine("\nSet-Up Successful");
            Console.WriteLine("\nPress any key to continue to the Start-Up screen.\n");
            Console.ReadKey();
>>>>>>> eb65b5980d6396aa7e809453e1864eaf5b9bb8be

            StartUpScreen.GoToStartUpScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);

            MainMenuScreen.GoToMainScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);
            MainOrExit.GoToMainOrExit(EJ_Checking, EJ_CreditCard, EJ_Loan);
            LoginScreen.GoToLoginScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);
            PersonalInformation.PIChangeAnnualSalary.GoToChangeAnnualSalary(EJ_Checking, EJ_CreditCard, EJ_Loan);
            StartUpScreen.GoToStartUpScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);

            BankAccount.BankAccountMainScreen.GoToBankAccountMainScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);
            BankAccount.BACheckBalance.GoToBankAccountBalance(EJ_Checking, EJ_CreditCard, EJ_Loan);
            BankAccount.BADeposit.GoToBankAccountDeposit(EJ_Checking, EJ_CreditCard, EJ_Loan);
            BankAccount.BAWithdrawal.GoToBankAccountWithdrawal(EJ_Checking, EJ_CreditCard, EJ_Loan);

            CreditCard.CreditCardMainScreen.GoToCreditCardMainScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);
            //More Options Here

            Loans.LoansMainScreen.GoToLoansMainScreen(EJ_Checking, EJ_CreditCard, EJ_Loan);
            Loans.LCheckLoanDetails.GoToCheckLoanDetails(EJ_Checking, EJ_CreditCard, EJ_Loan);
            Loans.LCheckLoanPaymentHIstory.GoToCheckLoanPaymentHistory(EJ_Checking, EJ_CreditCard, EJ_Loan);
            Loans.LMakeLoanPayment.GoToMakeLoanPayment(EJ_Checking, EJ_CreditCard, EJ_Loan);
        }
    }
}
