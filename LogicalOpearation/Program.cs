using System;



namespace LogicalOperation
{

    public class Program
    {
        public static bool IsTwenty(int num)
        {
            for (int j = 1; j <= 20; j++)
            {
                if (num % j != 0)
                {
                    return false;
                }
                else if (num % j == 0 && num == 20)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool IsThirty(int num)
        {
            for (int j = 1; j <= 30; j++)
            {
                if (num % j != 0)
                {
                    return false;
                }
                else if (num % j == 0 || num == 30)
                {
                    return true;
                }
            }
            return false;
        }

        public static int Shift(int a)
        {

            int b = a >> 3;
            return b;


        }


        static void Main(string[] args)
        {
            Console.Write("Enter a numbers: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\result of  Opearation  is : {0} \n",Shift (number1));


        }


    }
}