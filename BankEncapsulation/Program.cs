namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance;
        public double Balance { get; set; }
        
        
        public BankAccount()
        {
            Balance = _balance;
        }

        
        public void Deposit(double amount)
        {
            Balance += amount;

        }

        public double GetBalance()
        {
            return Balance;
        }


        public void Withdraw(double amount)
        {
            Balance -= amount;
        }

        public void BankingHistory()
        {

        }

        

        public static void Main(string[] args)
        {
            ScreenSelect.SelectScreen();
            //BankAccount Erans_Checking = new BankAccount();           
            //Erans_Checking.Deposit(2500);
            //Console.WriteLine(Erans_Checking.GetBalance());
            //Erans_Checking.Withdraw(500);
            //Console.WriteLine(Erans_Checking.GetBalance());

        }
    }
}
