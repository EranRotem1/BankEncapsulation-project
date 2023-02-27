namespace BankEncapsulation
{
    public static class HardCodedUserInfoClass
    {
        private static string _loginUserName = "Eran.Jack";
        private static string LoginUserName //Creating Property: a member that provides a mechanism to read, write, or compute the value of a private field.
        {
            get { return _loginUserName; }
            set { _loginUserName = value; }
        }

        private static string _loginPassword = "TrueCoders";
        private static string LoginPassword //Creating Property: a member that provides a mechanism to read, write, or compute the value of a private field.
        {
            get { return _loginPassword; }
            set { _loginPassword = value; }
        }
        private static double _annualIncome = 120000;
        private static double AnnualIncome //Creating Property: a member that provides a mechanism to read, write, or compute the value of a private field.
        {
            get { return _annualIncome; }
            set { _annualIncome = value; }
        }

        public static string GetUserName()
        {
            return LoginUserName;
        }
        public static string GetPassword()
        {
            return LoginPassword;
        }
        public static double GetAnnualIncome()
        {
            return AnnualIncome;
        }

        public static void SetAnnualIncome(double amount)
        {
            AnnualIncome = amount;
        }

        public static void SetPassword(string password)
        {
            LoginPassword = password;
        }

        public static void SetUserName(string userName)
        {
            LoginUserName = userName;
        }
    }
}
