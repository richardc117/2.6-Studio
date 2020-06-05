using System;
using System.Collections.Generic;
using System.Text;

namespace _2._6_Studio
{
    class NumCheck
    {
        public static double CheckIfNum(string input)
        {
            while(!double.TryParse(input, out double result))
            {
                Console.WriteLine("Please input a number");
                input = Console.ReadLine();
            }

            return double.Parse(input);
        }
    }
}
