﻿using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
            MysticNumbers myMysticNumbers = new MysticNumbers();
            // myMysticNumbers.ThreeNumbers(3,2,1);
            Console.WriteLine(myMysticNumbers.ThreeNumbers(3, 2, 1)); //15.01
            Console.WriteLine(myMysticNumbers.ThreeNumbers(1, 3, 2));
            Console.WriteLine(myMysticNumbers.ThreeNumbers(1, 1, 2));
            Console.ReadLine();
            Console.WriteLine(myMysticNumbers.TwoNumbers(1, 2)); //15.02

            Console.WriteLine(myMysticNumbers.FourNumbers(15, 3, 76, 192));
            // The LAST line of code should be ABOVE this line
        }
    }
}
