using BankEncapsulation.CreditCard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.BankAccount
{
    internal class BankAccount
    {
        private static double _balance;
        private static double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        BATransactionHistory myBATransactionHistory = new BATransactionHistory(); //creates new instance of transaction history (both debits and credits)

        public BankAccount(double amount) //Custom Constructor. Creates new bank account.
        {
            Balance = amount;
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

        public void CreateTestLogOut(double amount) //Money going out of the account
        {

            DateTime entry0 = new DateTime(2016, 2, 11, 5, 10, 20);
            DateTime entry1 = new DateTime(2017, 3, 13, 5, 10, 20);
            DateTime entry2 = new DateTime(2018, 4, 15, 5, 10, 20);
            DateTime entry3 = new DateTime(2019, 5, 17, 5, 10, 20);
            DateTime entry4 = new DateTime(2020, 6, 19, 5, 10, 20);
            DateTime entry5 = new DateTime(2020, 8, 23, 5, 10, 20);
            DateTime entry6 = new DateTime(2022, 10, 27, 5, 10, 20);


            //Creates Combined Payment and Purchase History Log
            BATransaction transaction0 = new BATransaction(entry0, entry0.Year, entry0.Month, entry0.Day, "Credit", amount, Balance - amount);
            Withdraw(amount);
            myBATransactionHistory.BATransactionHist_0.Add(transaction0);

            BATransaction transaction1 = new BATransaction(entry1, entry1.Year, entry1.Month, entry1.Day, "Credit", amount, Balance - amount);
            Withdraw(amount);
            myBATransactionHistory.BATransactionHist_0.Add(transaction1);

            BATransaction transaction2 = new BATransaction(entry2, entry2.Year, entry2.Month, entry2.Day, "Credit", amount, Balance - amount);
            Withdraw(amount);
            myBATransactionHistory.BATransactionHist_0.Add(transaction2);

            BATransaction transaction3 = new BATransaction(entry3, entry3.Year, entry3.Month, entry3.Day, "Credit", amount, Balance - amount);
            Withdraw(amount);
            myBATransactionHistory.BATransactionHist_0.Add(transaction3);

            BATransaction transaction4 = new BATransaction(entry4, entry4.Year, entry4.Month, entry4.Day, "Credit", amount, Balance - amount);
            Withdraw(amount);
            myBATransactionHistory.BATransactionHist_0.Add(transaction4);

            BATransaction transaction5 = new BATransaction(entry5, entry5.Year, entry5.Month, entry5.Day, "Credit", amount, Balance - amount);
            Withdraw(amount);
            myBATransactionHistory.BATransactionHist_0.Add(transaction5);

            BATransaction transaction6 = new BATransaction(entry6, entry6.Year, entry6.Month, entry6.Day, "Credit", amount, Balance - amount);
            Withdraw(amount);
            myBATransactionHistory.BATransactionHist_0.Add(transaction6);

            Console.WriteLine("Bank Account Credit log creation successful.\n\n");
        }

        public void CreateTestLogIn(double amount) //Money going into the account
        {
            DateTime entry0 = new DateTime(2016, 2, 10, 5, 10, 20);
            DateTime entry1 = new DateTime(2017, 3, 12, 5, 10, 20);
            DateTime entry2 = new DateTime(2018, 4, 14, 5, 10, 20);
            DateTime entry3 = new DateTime(2019, 5, 16, 5, 10, 20);
            DateTime entry4 = new DateTime(2020, 6, 18, 5, 10, 20);
            DateTime entry5 = new DateTime(2020, 8, 22, 5, 10, 20);
            DateTime entry6 = new DateTime(2023, 1, 26, 5, 10, 20);

            //Creates Combined Payment and Purchase History Log
            BATransaction transaction0 = new BATransaction(entry0, entry0.Year, entry0.Month, entry0.Day, "Debit", amount, Balance + amount);
            Deposit(amount);
            myBATransactionHistory.BATransactionHist_0.Add(transaction0);

            BATransaction transaction1 = new BATransaction(entry1, entry1.Year, entry1.Month, entry1.Day, "Debit", amount, Balance + amount);
            Deposit(amount);
            myBATransactionHistory.BATransactionHist_0.Add(transaction1);

            BATransaction transaction2 = new BATransaction(entry2, entry2.Year, entry2.Month, entry2.Day, "Debit", amount, Balance + amount);
            Deposit(amount);
            myBATransactionHistory.BATransactionHist_0.Add(transaction2);

            BATransaction transaction3 = new BATransaction(entry3, entry3.Year, entry3.Month, entry3.Day, "Debit", amount, Balance + amount);
            Deposit(amount);
            myBATransactionHistory.BATransactionHist_0.Add(transaction3);

            BATransaction transaction4 = new BATransaction(entry4, entry4.Year, entry4.Month, entry4.Day, "Debit", amount, Balance + amount);
            Deposit(amount);
            myBATransactionHistory.BATransactionHist_0.Add(transaction4);

            BATransaction transaction5 = new BATransaction(entry5, entry5.Year, entry5.Month, entry5.Day, "Debit", amount, Balance + amount);
            Deposit(amount);
            myBATransactionHistory.BATransactionHist_0.Add(transaction5);

            BATransaction transaction6 = new BATransaction(entry6, entry6.Year, entry6.Month, entry6.Day, "Debit", amount, Balance + amount);
            Deposit(amount);
            myBATransactionHistory.BATransactionHist_0.Add(transaction6);

            Console.WriteLine("Bank Account Debit log creation successful.\n\n");
        }

    }
}

