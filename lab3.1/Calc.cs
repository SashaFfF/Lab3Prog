using System;
using System.Collections.Generic;
using System.Text;

namespace lab3._1
{
    public class Calc
    {
        public static int Replacement(int a)
        {
            if (a % 2 == 0) 
            {
                return a / 2;
            }
            else
            {
                return 0;
            }
        }
    }
}
