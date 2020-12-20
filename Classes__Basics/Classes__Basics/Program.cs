using System;

namespace Classes__Basics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Create an object of my class
            // an instance of Human
            Human ellis = new Human("Ellis", "Trickett", "Blue", 25);
            Human dave = new Human("Dave", "Smith", "Brown", 1);
            ellis.IntroduceMyself();
            dave.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
