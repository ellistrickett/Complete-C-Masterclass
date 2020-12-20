using System;

namespace Hello_World
{ 
    class Program
    {

        public static void Main(string[] args)
        {
            string name1 = "Ellis";
            string name2 = "Mike";
            string name3 = "Steve";

            GreetFriend(name1);
            GreetFriend(name2);
            GreetFriend(name3);
            Console.Read();
        }

        public static void GreetFriend(string name)
        {
            Console.WriteLine("Hi " + name + ", my friend!");
        }
    }
}
