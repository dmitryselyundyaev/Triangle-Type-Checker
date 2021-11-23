using System;

namespace TriangleTypeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Triangle MyTriangle = new Triangle();
                Console.Write("Enter first side  = ");
                var WritedFirstValue = double.Parse(Console.ReadLine());
                Console.Write("Enter second side = ");
                var WritedSecondValue = double.Parse(Console.ReadLine());
                Console.Write("Entre hypotenuse = ");
                var WritedThirdValue = double.Parse(Console.ReadLine());
                MyTriangle.TriangleConstructor(WritedFirstValue, WritedSecondValue, WritedThirdValue);
                Console.WriteLine(MyTriangle.TriangleTypeByLength());
                Console.WriteLine("______________________________________________");
            }
        }
    }
}
