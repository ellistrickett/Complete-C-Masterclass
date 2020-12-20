using System;

namespace Hello_World
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string myname = "Ellis";
            string message = "My name is " + myname;

            string capsMessage = message.ToUpper();

            string lowerCaseMessage = message.ToLower();

            Console.WriteLine(lowerCaseMessage);
            Console.Read();
        }
    }
}
