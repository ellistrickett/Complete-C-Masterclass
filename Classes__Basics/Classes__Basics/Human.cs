using System;

namespace Classes__Basics
{
    // this class is a blueprint for a datatype
    class Human
    {   
        // member variable
        public string firstName = "Michael";
        public string lastName = "Jones";

        // member
        public void IntroduceMyself()
        {
            Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
        }
    }
}
