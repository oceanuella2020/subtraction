using System;

namespace subtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber;
            int secondnumber;
            int result;

            Console.Write("Enter your first number: ");
            firstnumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter your second number: ");
            secondnumber = Int32.Parse(Console.ReadLine());


            result = firstnumber - secondnumber;
            Console.WriteLine("Your result is " + result);

        }
    }
}
