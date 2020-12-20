using System;

namespace Switch_Statement
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int age = 19;

            switch(age)
            {
                case 15:
                    Console.WriteLine("Too young to party in the club!");
                    break;
                case 25:
                    Console.WriteLine("Good to go!");
                    break;
                default:
                    Console.WriteLine("How old are you then?");
                    break;
            }

            Console.Read();
        }
    }
}
