using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using BankEncapsulation.BankAccount;
using Microsoft.VisualBasic.FileIO;

namespace BankEncapsulation
{
    public class ScreenSelect
    {
        //Screen selection
        public static int SelectScreen(int loopStart, int loopEnd)
        {
            Console.WriteLine("Please enter the digit of your selection:\n\n");

            int fromOne = 1;
            int difference = loopStart - fromOne; //10
            for (int i = loopStart; i <= loopEnd; i++)
            {
                Console.WriteLine(($"{fromOne}. {Enum.GetName(typeof(Options), i)}"));
                fromOne++;
            }
            Console.WriteLine();
            var optionNumber = Enumerable.Range(loopStart, loopEnd).ToArray();
            string strOption = Console.ReadLine();

            bool isInRange = false;
            int optionChosen = -1;
            bool moveOn = false;

            bool success = int.TryParse(strOption, out optionChosen);
            if (success == true)
            {

                optionChosen += difference;
                if (optionChosen <= loopEnd && optionChosen >= loopStart)
                {
                    isInRange = optionNumber.Contains(optionChosen) == true ? true : false;
                    if (isInRange == true)
                    {
                        moveOn = true;
                    }
                }  
            }
            else
            {
                moveOn = false;
            }

            if (moveOn == false)
            {
                while (isInRange == false)
                {
                    Console.WriteLine("\nInvalid Entry: Please enter selection using only digits that are within the range.\n");
                    strOption = Console.ReadLine();
                    success = int.TryParse(strOption, out optionChosen);
                    if (success == true)
                    {
                        optionChosen += difference;
                        if (optionChosen <= loopEnd && optionChosen >= loopStart)
                        {
                            isInRange = optionNumber.Contains(optionChosen) == true ? true : false;
                            if (isInRange == true)
                            {
                                break;
                            }
                        }
                    }
                }
            }
            return optionChosen;
        }
    }
}
