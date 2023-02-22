using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation.BankAccount
{
    internal class BATransaction
    {
        public BATransaction(DateTime date, int year, int month, int day, string transactionType, double transactionAmt, double newBal) //Custom Constructor
        {
            Date = date;
            Year = year;
            Month = month;
            Day = day;
            TransactionType = transactionType;
            TransactionAmt = transactionAmt;
            NewBal = newBal;
        }

        public DateTime Date { get; set; } //Property
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string TransactionType { get; set; }
        public double TransactionAmt { get; set; }
        public double NewBal { get; set; }
        
    }
}
