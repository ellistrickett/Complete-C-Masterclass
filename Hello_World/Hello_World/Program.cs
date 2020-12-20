using System;

namespace Hello_World
{ 
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine(Divide(100,13));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
