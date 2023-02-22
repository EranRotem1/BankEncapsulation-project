using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.CreditCard
{
    internal class CCTransaction
    {
        public CCTransaction(DateTime date, int year, int month, int day, string transactionType, double transactionAmt, double newCredit, double newBal) //Custom Constructor
        {
            Date = date;
            Year = year;
            Month = month;
            Day = day;
            TransactionType = transactionType;
            TransactionAmt = transactionAmt;
            NewCredit = newCredit;
            NewBal = newBal;
        }

        public DateTime Date { get; set; } //Property
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string TransactionType { get; set; }
        public double TransactionAmt { get; set; }
        public double NewCredit { get; set; }
        public double NewBal { get; set; }
    }
}
