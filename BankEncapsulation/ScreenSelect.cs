using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BankEncapsulation.BankAccount;

namespace BankEncapsulation
{
    public class ScreenSelect
    {
        //Screen selection 
        public enum Options
        {
            personal = 1,
            account,
            credit_card,
            loans,
            help
        }
        public static Options currentScreen;

        public static void SelectScreen()
        {
            Console.WriteLine("1. Personal info\n2. Account info\n3. Credit Cards\n4. Loans\n5. Help");
            currentScreen = (Options)ValidInput(5);
            //temp for test purposes
            //Console.WriteLine(currentScreen);
        }
        public static int ValidInput(int options)
        {
            var optionNumber = Enumerable.Range(1, options).ToArray();
            int user = int.Parse(Console.ReadLine());
            while (!optionNumber.Contains(user))
            {
                Console.WriteLine("Please select valid option:");
                user = int.Parse(Console.ReadLine());
            }
            return user;
        }

    }
}
