using System;

namespace CODECHALLENGE1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter a number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter a number");
            int num2 = int.Parse(Console.ReadLine());
            numOperator(num1,num2);
        }
        public static void numOperator(int num1, int num2)
        {
            if(num1 >= num2)
            {
               Console.WriteLine(num1 - num2);
            }
            else
            {
                Console.WriteLine(num2 - num1);
            }
        }
    }
}
