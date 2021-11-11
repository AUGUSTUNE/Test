using System;

namespace MathOp
{
    public class Mathop
    {
        public static int Sum(int num1, int num2)
        {
            int total;
            total = num1 + num2;
            return total;
        }
        public static int Subtract(int num1, int num2)
        {
            int total;
            total = num1 - num2;
            return total;
        }
        public static int Multiply(int num1, int num2)
        {
            int total;
            total = num1 * num2;
            return total;
        }
        public static int Divide(int num1, int num2)
        {
            int total;
            total = num1 / num2;
            return total;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter two numbers: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nThe diff of two numbers is : {0} \n", Subtract(number1, number2));

            Console.ReadLine();
        }
    }
}
