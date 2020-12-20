using System;

namespace Classes__Basics
{
    // this class is a blueprint for a datatype
    class Human
    {   
        // member variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //default contructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // parameterized constructor
        public Human(string firstName, string lastName, string eyeColor)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
        }

        // parameterized constructor
        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        // parameterized constructor
        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        // member
        public void IntroduceMyself()
        {
            if (age != 0 && lastName != null && eyeColor != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}, I have {2} eyes and I am {3} year old", firstName, lastName, eyeColor, age);
            }
            else if (lastName != null && eyeColor != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1} and I have {2} eyes", firstName, lastName, eyeColor);
            }
            else if (lastName != null && firstName != null)
            {
                Console.WriteLine("Hi, I'm {0} {1}", firstName, lastName);
            }
            else if (firstName != null)
            {
                Console.WriteLine("Hi, I'm {0}", firstName);
            }
           
        }
    }
}
