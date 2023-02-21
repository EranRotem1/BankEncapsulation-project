
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
