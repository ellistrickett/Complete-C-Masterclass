using System;

namespace Hello_World
{ 
    class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number...");
            string num1Input = Console.ReadLine();

            Console.WriteLine("Enter another number...");
            string num2Input = Console.ReadLine();

            int num1 = int.Parse(num1Input);
            int num2 = int.Parse(num2Input);

            Console.WriteLine(num1 + " plus " + num2 + " equals " + Add(num1, num2));
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
