using System;

namespace Hello_World
{ 
    class Program
    {

        static string username;
        static string password;
        static bool loggedIn = false;

        public static void Main(string[] args)
        {
            Register();

            Login();
        }

        public static void Register()
        {
            Console.WriteLine("Please type in your username");
            username = Console.ReadLine();

            Console.WriteLine("Please type in your password");
            password = Console.ReadLine();
        }

        public static void Login()
        {
            Console.WriteLine("To Log in type in your username");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("To Log in type in your password");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Login Successful");
                }
            }
            else
            {
                Console.WriteLine("Login failed");
            }
        }
    }
}
