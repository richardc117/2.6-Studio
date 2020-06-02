using System;


namespace _2._6_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle();

            Console.WriteLine("Enter a radius:");

            circle.radius = CheckIfNum.CheckNum(Console.ReadLine());
            circle.GetArea();
            

            Console.WriteLine("The area of the circle is {0}", circle.area);

        }
    }
}
