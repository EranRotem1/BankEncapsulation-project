namespace BankEncapsulation
{
    public enum Options
    {
        //**Main Screen Options**
        Personal_Information = 1,
        Bank_Account,
        Credit_Card,
        Loans,
        Help,

        //**Credit Card Check Transaction History Options**
        Purchase = 6,
        Payment,
        All,

        //**Return to Main Menu / Log Off**
        Returnt_To_Main_Menu_Screen = 9,
        Logout,

        //**Start-Up Screen **
        Login = 11,
        Forgot_Password,
        Create_New_Account,

        //Credit Card Main
        Check_Available_Credit = 14,
        Check_Current_Balance,
        Make_Purchase,
        Make_Payment,
        Check_Transaction_History,
        Check_Credit_Limit,
        Change_Credit_Limit,

        //Loans Main
        Apply_For_Loan = 21,
        Check_Current_Loan_Details,
        Make_Loan_Payment,
        Check_Loan_Payment_History,

        //Bank Account Main
        Bank_Account_Deposit = 25,
        Bank_Account_GetBalance,
        Bank_Account_Withdraw,

        //Personal Information Main
        Change_Annual_Salary = 28,
        Change_Username,
        Change_Password,

        //Credit Card Transaction History - SubMenu
        Check_All_Transactions = 31,
        Check_Last_Statment,
        Check_History_Range
    }
}