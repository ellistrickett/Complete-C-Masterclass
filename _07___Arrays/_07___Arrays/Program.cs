using System;

namespace _07___Arrays
{
    class MainClass
    {
        static void Main(string[] args)
        {
            string[] friends = { "Ellis", "Steve", "Michael", "Jack", "June" };

            int counter = 0;
            foreach(string i in friends)
            {
                Console.WriteLine("Hey {0}", i);
                counter++;
            }

            Console.ReadKey();
        }
    }
}
