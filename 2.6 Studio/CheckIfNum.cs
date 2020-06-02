using System;
using System.Collections.Generic;
using System.Text;

namespace _2._6_Studio
{
    public static class CheckIfNum
    {
        public static double CheckNum(string input)
        {
            while (!double.TryParse(input, out double result))
            {
                Console.Clear();
                Console.WriteLine("Please only type a number");
                input = Console.ReadLine();
            }

            return double.Parse(input);
        }
    }
}
