using System;

namespace Classes__Basics
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Create an object of my class
            // an instance of Human
            Human denis = new Human();
            // access public variable from outside, and even change it
            denis.firstName = "Denis";
            denis.lastName = "Smith";
            // call method of a class
            denis.IntroduceMyself();

            Human michael = new Human();
            michael.IntroduceMyself();

            Console.ReadKey();
        }
    }
}
