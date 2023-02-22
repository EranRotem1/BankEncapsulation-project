using BankEncapsulation.BankAccount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.Loans
{
    internal class Loan
    {
        private double _loanBalance;
        private double LoanBalance
        {
            get { return _loanBalance; }
            set { _loanBalance = value; }
        }

        LLoanTransactionHistory myLTransactionHistory = new LLoanTransactionHistory(); //creates new instance of transaction history (both purchases and payments)
        public Loan(double amount) 
        {
            LoanBalance = amount;
        }

        public void LLoanPayment(double amount)
        {
            LoanBalance -= amount;
        }

        public double LGetLoanBalance()
        {
            return LoanBalance;
        }

        public void LCreateTestLogLoanPayment(double amount) //Money going out of the account
        {

            DateTime entry0 = new DateTime(2016, 2, 11, 5, 10, 20);
            DateTime entry1 = new DateTime(2017, 3, 13, 5, 10, 20);
            DateTime entry2 = new DateTime(2018, 4, 15, 5, 10, 20);
            DateTime entry3 = new DateTime(2019, 5, 17, 5, 10, 20);
            DateTime entry4 = new DateTime(2020, 6, 19, 5, 10, 20);
            DateTime entry5 = new DateTime(2020, 8, 23, 5, 10, 20);
            DateTime entry6 = new DateTime(2022, 10, 27, 5, 10, 20);


            //Creates Combined Payment and Purchase History Log
            LLoanTransaction transaction0 = new LLoanTransaction(entry0, entry0.Year, entry0.Month, entry0.Day, "Payment", amount, LoanBalance - amount);
            LLoanPayment(amount);
            myLTransactionHistory.LTransactionHist_0.Add(transaction0);

            LLoanTransaction transaction1 = new LLoanTransaction(entry1, entry1.Year, entry1.Month, entry1.Day, "Payment", amount, LoanBalance - amount);
            LLoanPayment(amount);
            myLTransactionHistory.LTransactionHist_0.Add(transaction1);

            LLoanTransaction transaction2 = new LLoanTransaction(entry2, entry2.Year, entry2.Month, entry2.Day, "Payment", amount, LoanBalance - amount);
            LLoanPayment(amount);
            myLTransactionHistory.LTransactionHist_0.Add(transaction2);

            LLoanTransaction transaction3 = new LLoanTransaction(entry3, entry3.Year, entry3.Month, entry3.Day, "Payment", amount, LoanBalance - amount);
            LLoanPayment(amount);
            myLTransactionHistory.LTransactionHist_0.Add(transaction3);

            LLoanTransaction transaction4 = new LLoanTransaction(entry4, entry4.Year, entry4.Month, entry4.Day, "Payment", amount, LoanBalance - amount);
            LLoanPayment(amount);
            myLTransactionHistory.LTransactionHist_0.Add(transaction4);
                
            LLoanTransaction transaction5 = new LLoanTransaction(entry5, entry5.Year, entry5.Month, entry5.Day, "Payment", amount, LoanBalance - amount);
            LLoanPayment(amount);
            myLTransactionHistory.LTransactionHist_0.Add(transaction5);

            LLoanTransaction transaction6 = new LLoanTransaction(entry6, entry6.Year, entry6.Month, entry6.Day, "Payment", amount, LoanBalance - amount);
            LLoanPayment(amount);
            myLTransactionHistory.LTransactionHist_0.Add(transaction6);

            Console.WriteLine("\nLoan Payment log creation successful");
        }

    }
}
