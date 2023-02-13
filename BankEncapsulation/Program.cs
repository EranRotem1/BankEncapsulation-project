namespace BankEncapsulation
{
    public class BankAccount
    {
        private double _balance;
        public double Balance
        { get ; set ; }

        public BankAccount(double amount)
        {
            _balance = amount;
        }
        
        public void Deposit(double amount)
        {
            _balance += amount;

        }
       
        public double GetBalance()
        {
            return _balance;
        }

       
        public void Withdraw(double amount) 
        {
            _balance -= amount;  
        }
        //write method to control workflow
       
        static void Main(string[] args)
        {
            BankAccount Erans_Checking = new BankAccount(0);           
            Erans_Checking.Deposit(2500);
            Console.WriteLine(Erans_Checking.GetBalance());
            Erans_Checking.Withdraw(500);
            Console.WriteLine(Erans_Checking.GetBalance());

        }
    }
}
