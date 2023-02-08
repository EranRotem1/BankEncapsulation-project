namespace BankEncapsulation
{
    public class BankAccount
    {
        private double balance;
        public double Balance
        { get ; set ; }

        public BankAccount(double amount)
        {
            balance = amount;
        }
        public void Deposit()
        {
            Console.WriteLine("Deposit amount: ");
            var amount = int.Parse(Console.ReadLine());
            balance += amount;

        }
        public void GetBalance()
        {
            Console.WriteLine( $"Balance: {balance}");
        }
        public void Withdraw() 
        {
            Console.WriteLine("Withdraw amount: ");
            var amount = int.Parse(Console.ReadLine());
            balance -= amount;  
        }
        //write method to control workflow
        static void Main(string[] args)
        {
            BankAccount Erans_Checking = new BankAccount(0);           
            Erans_Checking.Deposit();
            Erans_Checking.GetBalance();
            Erans_Checking.Withdraw();
            Erans_Checking.GetBalance();

        }
    }
}
