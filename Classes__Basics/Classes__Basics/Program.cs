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
            Human dave = new Human("Dave", "Smith", "Brown");
            ellis.IntroduceMyself();
            dave.IntroduceMyself();  

            Human basicHuman = new Human();
            basicHuman.IntroduceMyself();

            Human natalie = new Human("Natalie");
            natalie.IntroduceMyself();

            Human michael = new Human("Michael", "Miller");
            michael.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
