using System;

namespace Hello_World
{  // Class names like ClientActivity
    class Program
    {
        public static void Main(string[] args)
        {
            // implicit conversion
            int num = 12390532;
            long bigNum = num;

            float myFloat = 13.37F;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
            // explicit conversion
            // cast Double into int;
            myInt = (int)myDouble;

            // typeConversion
            string myString = myDouble.ToString(); //"13.376"
            string floatString = myFloat.ToString();
            bool sunIsShining = true;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);
            Console.Read();
        }
    }
}
