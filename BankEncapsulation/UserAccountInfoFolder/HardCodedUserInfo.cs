namespace BankEncapsulation
{
    public class HardCodedUserInfoClass
    {
        private string _loginUserName = "Eran.Jack";
        private string LoginUserName //Creating Property: a member that provides a mechanism to read, write, or compute the value of a private field.
        {
            get { return _loginUserName; }
            set { _loginUserName = value; }
        }

        private string _loginPassword = "TrueCoders";
        private string LoginPassword //Creating Property: a member that provides a mechanism to read, write, or compute the value of a private field.
        {
            get { return _loginPassword; }
            set { _loginPassword = value; }
        }
        private double _annualIncome = 120000;
        private double AnnualIncome //Creating Property: a member that provides a mechanism to read, write, or compute the value of a private field.
        {
            get { return _annualIncome; }
            set { _annualIncome = value; }
        }

        public string GetUserName()
        {
            return LoginUserName;
        }
        public string GetPassword()
        {
            return LoginPassword;
        }
        public double GetAnnualIncome()
        {
            return AnnualIncome;
        }

    }
}