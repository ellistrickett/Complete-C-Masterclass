using System;

namespace Hello_World
{  // Constants are immutable values which are known
    // at compile time and do not change for the life of the program
    class Program
    {
        // constants as fields
        const double pI = 3.14159265359;
        const int weeks = 52, month = 12;
        const string birthday = "24.10.1995";

        public static void Main(string[] args)
        {
            Console.WriteLine("My Birthday is always going to be: {0}", birthday);
            Console.ReadKey();
        }
    }
}
