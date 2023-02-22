
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using BankEncapsulation.BankAccount;



namespace BankEncapsulation
{   
    //public enum Options
    //    {
    //        personal = 1,
    //        account,
    //        credit_card,
    //        loans,
    //        help
    //    }
    //public class ScreenSelect1
    //{
    //    //Screen selection 
        
    //    public static Options currentScreen;

    //    public static void SelectScreen()
    //    {
    //        Console.WriteLine("1. Personal info\n2. Account info\n3. Credit Cards\n4. Loans\n5. Help");
    //        currentScreen = (Options)ValidInput(5);
    //        //ConsoleWrite outside of the method, input an enum as param, use ValidInput on that, in VI argument put Enum.GetNames(typeof(arg))
    //    }
    //    //public static int ValidInput(int options)
    //    //{
    //    //    var optionNumber = Enumerable.Range(1, options).ToArray();
    //    //    int user = int.Parse(Console.ReadLine());
    //    //    while (!optionNumber.Contains(user))


    public class ScreenSelect
    {
        public static int SelectScreen(int loopStart, int loopEnd)
        {
            Console.WriteLine("Please enter the digit of your selection:\n");

            int fromOne = 1;
            int difference = loopStart - fromOne;
            for (int i = loopStart; i <= loopEnd; i++)
            {
                Console.WriteLine(($"{fromOne}. {Enum.GetName(typeof(Options), i)}"));
                fromOne++;
            }
            Console.WriteLine();
            var optionNumber = Enumerable.Range(loopStart, loopEnd).ToArray();
            int optionChosen = int.Parse(Console.ReadLine());
            optionChosen += difference;
            while (!optionNumber.Contains(optionChosen))
            {
                Console.WriteLine("Please enter valid digit:");
                optionChosen = int.Parse(Console.ReadLine());
                optionChosen+= difference;
            }
            return optionChosen;
        }
    }
}
