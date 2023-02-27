using BankEncapsulation.Loans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BankEncapsulation.CreditCard
{
    internal class CreditCard
    {
        private double _maxCredit;
        private double MaxCredit //Creating Property: a member that provides a mechanism to read, write, or compute the value of a private field.
        {
            get { return _maxCredit; }
            set { _maxCredit = value; }
        }

        private double _usedCredit;
        private double UsedCredit
        {
            get { return _usedCredit; }
            set { _usedCredit = value; }
        }

        private double _availableCredit;
        private double AvailableCredit
        {
            get { return _availableCredit; }
            set { _availableCredit = value; }
        }

        CCTransactionHistory myCCTransactionHistory = new CCTransactionHistory(); //creates new instance of transaction history (both purchases and payments)

        public CreditCard(double amount) //Creates Credit Card. Sets max avaialble credit limit. Custom Custructor.
        {
            MaxCredit = amount;
            UsedCredit = 0;
            AvailableCredit = MaxCredit - UsedCredit;
            DateTime entry0 = new DateTime(2015, 12, 31, 5, 10, 20);

            //Creates Combined Payment and Purchase History Log
            CCTransaction transaction0 = new CCTransaction(entry0, entry0.Year, entry0.Month, entry0.Day, "Account Creation", 0, MaxCredit - UsedCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction0);

        }

        public void CCCreateTestLogPayment(double amount) //Creates Fake Log - ONLY FOR TESTING PURPOSES
        {
            AvailableCredit = MaxCredit - UsedCredit;
            DateTime entry0 = new DateTime(2016, 2, 10, 5, 10, 20);
            DateTime entry1 = new DateTime(2017, 3, 12, 5, 10, 20);
            DateTime entry2 = new DateTime(2018, 4, 14, 5, 10, 20);
            DateTime entry3 = new DateTime(2019, 5, 16, 5, 10, 20);
            DateTime entry4 = new DateTime(2020, 6, 18, 5, 10, 20);
            DateTime entry5 = new DateTime(2020, 8, 22, 5, 10, 20);
            DateTime entry6 = new DateTime(2023, 1, 26, 5, 10, 20);

            UsedCredit -= amount;
            CCTransaction transaction0 = new CCTransaction(entry0, entry0.Year, entry0.Month, entry0.Day, "Payment", amount, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction0);

            UsedCredit -= amount;
            CCTransaction transaction1 = new CCTransaction(entry1, entry1.Year, entry1.Month, entry1.Day, "Payment", amount, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction1);

            UsedCredit -= amount;
            CCTransaction transaction2 = new CCTransaction(entry2, entry2.Year, entry2.Month, entry2.Day, "Payment", amount, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction2);

            UsedCredit -= amount;
            CCTransaction transaction3 = new CCTransaction(entry3, entry3.Year, entry3.Month, entry3.Day, "Payment", amount, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction3);

            UsedCredit -= amount;
            CCTransaction transaction4 = new CCTransaction(entry4, entry4.Year, entry4.Month, entry4.Day, "Payment", amount, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction4);

            UsedCredit -= amount;
            CCTransaction transaction5 = new CCTransaction(entry5, entry5.Year, entry5.Month, entry5.Day, "Payment", amount, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction5);

            UsedCredit -= amount;
            CCTransaction transaction6 = new CCTransaction(entry6, entry6.Year, entry6.Month, entry6.Day, "Payment", amount, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction6);

            Console.WriteLine("CC Payment log creation successful\n\n");
        }

        public void CCCreateTestLogPurchase(double amount) //Creates Fake Log - ONLY FOR TESTING PURPOSES
        {
            AvailableCredit = MaxCredit - UsedCredit;
            DateTime entry0 = new DateTime(2016, 1, 10, 5, 10, 20);
            DateTime entry1 = new DateTime(2017, 2, 12, 5, 10, 20);
            DateTime entry2 = new DateTime(2018, 3, 14, 5, 10, 20);
            DateTime entry3 = new DateTime(2019, 4, 16, 5, 10, 20);
            DateTime entry4 = new DateTime(2020, 5, 18, 5, 10, 20);
            DateTime entry5 = new DateTime(2020, 7, 22, 5, 10, 20);
            DateTime entry6 = new DateTime(2022, 9, 26, 5, 10, 20);

            UsedCredit += amount;
            CCTransaction transaction0 = new CCTransaction(entry0, entry0.Year, entry0.Month, entry0.Day, "Purchase", amount, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction0);

            UsedCredit += amount;
            CCTransaction transaction1 = new CCTransaction(entry1, entry1.Year, entry1.Month, entry1.Day, "Purchase", amount, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction1);

            UsedCredit += amount;
            CCTransaction transaction2 = new CCTransaction(entry2, entry2.Year, entry2.Month, entry2.Day, "Purchase", amount, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction2);

            UsedCredit += amount;
            CCTransaction transaction3 = new CCTransaction(entry3, entry3.Year, entry3.Month, entry3.Day, "Purchase", amount, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction3);

            UsedCredit += amount;
            CCTransaction transaction4 = new CCTransaction(entry4, entry4.Year, entry4.Month, entry4.Day, "Purchase", amount, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction4);

            UsedCredit += amount;
            CCTransaction transaction5 = new CCTransaction(entry5, entry5.Year, entry5.Month, entry5.Day, "Purchase", amount, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction5);

            UsedCredit += amount;
            CCTransaction transaction6 = new CCTransaction(entry6, entry6.Year, entry6.Month, entry6.Day, "Purchase", amount, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction6);

            Console.WriteLine("CC Purchase log creation successful.\n\n");
        }
        public double CCCheckAvailableCredit() //Check available credit limit (i.e. how much credit is unused)
        {
            return MaxCredit - UsedCredit;
        }

        public double CCCheckCurrentBalance() //Check how much is owed currently (i.e. how much credit has been used)
        {
            return UsedCredit;
        }

        public void CCMakePurchase(double amount, BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            CCCheckPurchaseAmt(amount, account, card, loan);
        }

        public void CCCheckPurchaseAmt(double amount, BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            amount = Math.Abs(amount);
            if (AvailableCredit == 0)
            {
                Console.WriteLine($"Error: Card Declined. Max credit limit of {MaxCredit} has been reached.\n\n");
                //throw new Exception($"Error: Card Declined. Max credit limit of {_maxCredit} has been reached.");
                MainOrExit.GoToMainOrExit(account, card, loan);
            }
            else if (AvailableCredit < amount)
            {
                Console.WriteLine($"Error: Purchase amount of ${amount} is greater than the current available credit limit of ${AvailableCredit}.\n\n");
                //throw new Exception($"Error: Purachase amount of ${amount} is greater than the current available credit limit of ${_availableCredit}.");
                MainOrExit.GoToMainOrExit(account, card, loan);
            }
            else
            {
                bool success = CCUseCredit(amount);

                if (success == true)
                {
                    Console.WriteLine("Purchase Successful\n\n");
                }
                Console.WriteLine("Would you like to make another purchase?\n\n");
                string yesNo = DoubleCheckSelection.DoubleCheckYesNo();

                if (yesNo == "Y")
                {
                    CCMakePurchaseClass.GoToMakePurchase(account, card, loan);
                }
                else
                {
                    MainOrExit.GoToMainOrExit(account, card, loan);
                }
            }
        }
        private bool CCUseCredit(double amount)
        {
            UsedCredit += amount;

            DateTime now = DateTime.Now;

            CCTransaction transaction1 = new CCTransaction(now, now.Year, now.Month, now.Day, "Purchase", amount, AvailableCredit, UsedCredit);

            myCCTransactionHistory.TransactionHist_0.Add(transaction1);

            return true;
        }
        public void CCCheckTransactionHistory(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan) //For all history
        {
            for (int i = 0; i < myCCTransactionHistory.TransactionHist_0.Count; i++)
            {
                CCPrintTransactionHistory(i);
            }

            MainOrExit.GoToMainOrExit(account, card, loan);
        }
        public void CCCheckLastStatement(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan) //Check last statement for prior billing cycle
        {
            DateTime now = DateTime.Now;
            int year;
            int lastMonth;
            year = now.Month == 1 ? now.Year - 1 : now.Year;
            lastMonth = now.Month == 1 ? 12 : now.Month - 1;

            CCCheckTransactionHistory(lastMonth, year, account, card, loan);
        }

        public void CCCheckTransactionHistory(int lastMonth, int year, BankAccount.BankAccount account, CreditCard card, Loans.Loan loan) //For Last Statement - example of method overload
        {
            bool atLeastOneTransaction = false;
            int i = 0;
            for (i = 0; i < myCCTransactionHistory.TransactionHist_0.Count; i++)
            {
                if (myCCTransactionHistory.TransactionHist_0[i].Month == lastMonth && myCCTransactionHistory.TransactionHist_0[i].Year == year)
                {
                    CCPrintTransactionHistory(i);
                    atLeastOneTransaction = true;
                }
            }
            if (atLeastOneTransaction == true)
            {
                Console.WriteLine();
                Console.WriteLine($"Statement Balance Due: ${myCCTransactionHistory.TransactionHist_0[myCCTransactionHistory.TransactionHist_0.Count - 1].NewBal}\n\n");
            }
            else
            {
                Console.WriteLine("There was no account activity within the last statement cycle.\n\n");
            }

            MainOrExit.GoToMainOrExit(account, card, loan);
        }
        public void CCCheckHistoryRange(BankAccount.BankAccount account, CreditCard card, Loans.Loan loan) //Check transaction history for specified period of time and type
        {
            Console.Clear();

            Console.WriteLine("What type of transaction would you like to display?\n");

            int loopStart = 6;
            int loopEnd = 8;
            string transactionType = "";

            int selectedOption = ScreenSelect.SelectScreen(loopStart, loopEnd);
            Console.WriteLine();

            //** Credit Card Transaction History Options **

            switch (selectedOption)
            {
                case 6: //Purchase
                    Console.WriteLine("You Selected \"Purchases\", Correct?\n");
                    transactionType = "Purchase";
                    break;

                case 7: //Payment
                    //Console.WriteLine("You Selected Payments, Correct?");
                    Console.WriteLine("You Selected \"Payments\", Correct?\n");
                    transactionType = "Payment";
                    break;

                case 8: //All
                    //Console.WriteLine("You Selected All, Correct?");
                    Console.WriteLine("You Selected \"All\", Correct?\n");
                    transactionType = "All";
                    break;

                default:
                    Console.WriteLine("Error: Invalid option selected. This should never happen.\n");
                    break;
            }

            //--------------------------------------------------------------------------------------
            string yesNo = DoubleCheckSelection.DoubleCheckYesNo();

            if (yesNo == "N")
            {
                CCCheckHistoryRange(account, card, loan);
            }

            DateTime startDate = ValidInputDates.SelectDate("start");
            Console.WriteLine();

            DateTime endDate = ValidInputDates.SelectDate("end");
            Console.WriteLine();

            Console.WriteLine($"Are the dates you entered below correct?\nStart Date: {startDate}\nEnd Date: {endDate}\n");

            yesNo = DoubleCheckSelection.DoubleCheckYesNo();
            Console.WriteLine();

            if (yesNo == "N")
            {
                CCCheckHistoryRange(account, card, loan);
            }

            if (transactionType == "All")
            {
                CCCheckTransactionHistory(startDate, endDate, account, card, loan);
            }
            else
            {
                CCCheckTransactionHistory(transactionType, startDate, endDate, account, card, loan);
            }
        }
        public void CCCheckTransactionHistory(string transactionType, DateTime startDate, DateTime endDate, BankAccount.BankAccount account, CreditCard card, Loans.Loan loan) //For transactions for specified period of time and type - method overload
        {
            for (int i = 0; i < myCCTransactionHistory.TransactionHist_0.Count; i++) //Front end will take care of applicable data range start I am thinking
            {
                if (myCCTransactionHistory.TransactionHist_0[i].Date >= startDate &&
                    myCCTransactionHistory.TransactionHist_0[i].Date <= endDate &&
                    myCCTransactionHistory.TransactionHist_0[i].TransactionType == transactionType)
                {
                    CCPrintTransactionHistory(i);
                }
            }
            MainOrExit.GoToMainOrExit(account, card, loan);
        }

        public void CCCheckTransactionHistory(DateTime startDate, DateTime endDate, BankAccount.BankAccount account, CreditCard card, Loans.Loan loan) //For transactions for specified period of time (prints all types) - method overload
        {
            for (int i = 0; i < myCCTransactionHistory.TransactionHist_0.Count; i++) //Front end will take care of applicable data range start I am thinking
            {
                if (myCCTransactionHistory.TransactionHist_0[i].Date >= startDate &&
                    myCCTransactionHistory.TransactionHist_0[i].Date <= endDate)
                {
                    CCPrintTransactionHistory(i);
                }
            }
            MainOrExit.GoToMainOrExit(account, card, loan);
        }

        public void CCPrintTransactionHistory(int i)
        {
            Console.WriteLine($"Transaction Type: {myCCTransactionHistory.TransactionHist_0[i].TransactionType}");
            Console.WriteLine($"Transaction Date: {myCCTransactionHistory.TransactionHist_0[i].Date}");
            Console.WriteLine($"Transaction Amount: ${myCCTransactionHistory.TransactionHist_0[i].TransactionAmt}");
            Console.WriteLine($"Avaialble Credit after Transaction: ${myCCTransactionHistory.TransactionHist_0[i].NewCredit}");
            Console.WriteLine($"Effective Balance after Transacation: ${myCCTransactionHistory.TransactionHist_0[i].NewBal}\n\n");
        }

        public double CCCheckCreditLimit() //Check available credit limit (i.e. how much credit is unused)
        {
            return MaxCredit;
        }
        public void CCMakeCredChange(double amount, BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            CCCheckCredLimChng(amount, account, card, loan);
        }

        public void CCCheckCredLimChng(double amount, BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            amount = Math.Abs(amount);
            double annualIncome = HardCodedUserInfoClass.GetAnnualIncome();
            bool success = false;
            if (amount > annualIncome / 12) //Note: Annual income hardcoded for now
            {
                Console.WriteLine($"Error: Credit Limit Change Request Denied.\n\n");
                //throw new Exception($"Error: Credit Limit Change Request Denied.");
            }
            else if (amount < UsedCredit)
            {
                Console.WriteLine($"Error: Outstanding balance of {UsedCredit} exceeds new requested credit limit ceiling.\n\n");
                //throw new Exception($"Error: Outstanding balance of {_usedCredit} exceeds new credit limit ceiling.");
            }
            else
            {
                success = CCChangeCreditLimit(amount);
            }

            if (success == true)
            {
                Console.WriteLine("\n---------------------------------------------------------------------------\n");
                Console.WriteLine($"Operation Successful: Credit limit is now changed to ${MaxCredit}.\n\n");
            }
            MainOrExit.GoToMainOrExit(account, card, loan);
        }

        private bool CCChangeCreditLimit(double amount)
        {
            MaxCredit = amount;
            AvailableCredit = MaxCredit - UsedCredit;
            return true;
        }


        public void CCMakePayment(double amount, BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            CCCheckPaymentAmt(amount, account, card, loan);
        }

        public void CCCheckPaymentAmt(double amount, BankAccount.BankAccount account, CreditCard card, Loans.Loan loan)
        {
            amount = Math.Abs(amount);
            Console.WriteLine($"Is the payment amount of ${amount} that you entered correct?\n");
            string yesNo = DoubleCheckSelection.DoubleCheckYesNo();

            if (yesNo == "N")
            {
                CCMakePaymentClass.GoToMakePayment(account, card, loan);
            }
            else
            {
                if (UsedCredit == 0)
                {
                    Console.WriteLine("Error: Balance is currently 0. No payment necessary.\n\n");
                    //throw new Exception("Error: Balance is currently 0. No payment necessary.");
                    MainOrExit.GoToMainOrExit(account, card, loan);
                }
                else if (UsedCredit < amount)
                {
                    Console.WriteLine($"Error: Payment amount of ${amount} is greater than your current outstanding balance of ${UsedCredit}.");
                    //throw new Exception($"Error: Payment aount of ${amount} is greater than the current outstanding balance of {_usedCredit}." +
                    MainOrExit.GoToMainOrExit(account, card, loan);
                }
                else
                {
                    bool success = CCCreditPayment(amount);

                    if (success == true)
                    {
                        Console.WriteLine("Payment Successful\n\n");
                    }
                    Console.WriteLine("Would you like to make another payment?\n\n");
                    yesNo = DoubleCheckSelection.DoubleCheckYesNo();

                    if (yesNo == "Y")
                    {
                        CCMakePaymentClass.GoToMakePayment(account, card, loan);
                    }
                    else
                    {
                        MainOrExit.GoToMainOrExit(account, card, loan);
                    }
                }
            }
        }
        private bool CCCreditPayment(double amount)
        {
            UsedCredit -= amount;

            DateTime now = DateTime.Now;

            CCTransaction transaction1 = new CCTransaction(now, now.Year, now.Month, now.Day, "Payment", amount * -1, AvailableCredit, UsedCredit);
            myCCTransactionHistory.TransactionHist_0.Add(transaction1);

            return true;
        }
    }
}
