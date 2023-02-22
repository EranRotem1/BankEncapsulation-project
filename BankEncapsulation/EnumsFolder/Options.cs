namespace BankEncapsulation
{
    public enum Options
    {
        //**Main Screen Options**
        PersonalInformation = 1,
        BankAccount,
        CreditCard,
        Loans,
        Help,

        //**Credit Card Check Transaction History Options**
        Purchase = 6,
        Payment,
        All,

        //**Return to Main Menu / Log Off**
        ReturntToMainMenu = 9,
        LogOut,

        //**Start-Up Screen **
        Login = 11,
        ForgotPassword,
        CreateNewAccount,

        //Credit Card Main
        CheckAvailableCredit = 14,
        CheckCurrentBalance,
        MakePurchase,
        CheckTransactionHistory,
        CheckLastStatement,
        MakeCreditChange,
        MakePayment,

        //Loans Main
        ApplyForLoan = 21,
        CheckCurrentLoanDetails,
        MakeLoanPayment,
        CheckLoanPaymentHistory,

        //Bank Account Main
        BankAccountDeposit = 25,
        BankAccountGetBalance,
        BankAccountWithdraw,

        //Personal Information Main
        ChangeUserName = 28,
        ChangeAnnualSalary,
        ChangePassword
    }
}