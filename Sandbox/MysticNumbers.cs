﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    class MysticNumbers
    {
        public int ThreeNumbers(int a, int b, int c)
        {
            int result;

            if (b > a)
            {
                result = b;
                if (c > b)
                {
                    result = c;
                }
            }
            else
            {
                result = a;
                if (c > a)
                {
                    result = c;
                }
            }

            return result;
        }

        /* Denne metode bruges til 15.02 i opgaven*/

        public int TwoNumbers(int a, int b)
        {

            int result;

            if (a > b)
            {
                result = a;
            }

            else
            {
                result = b;
            }

            return result;
        }


        public int FourNumbers(int a, int b, int c, int d)
        {
            int first = TwoNumbers(a,b);
            int second = TwoNumbers(c, d);
            int result = TwoNumbers(first, second);
            return result;
        }


    }

}

