using System;

namespace Hello_World
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 5;
            int sum = num1 + num2;
            

            double d1 = 3.5;
            double d2 = 1.337;
            double sumD = d1 / d2;
           
            float f1 = 3.5F;
            //Use casting
            //int divDandI = d1 / num2;

            Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
            Console.WriteLine(d1 + " divided by " + " and " + num2 + " is " + sumD);
            Console.Read();
        }
    }
}
