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

        }
    }
}
