using System;

namespace PropertiesC
{
    class MainClass
    {
        static void Main(string[] args)
        {
            Box box = new Box(5, 4, 10);
            Console.WriteLine("Volume is {0}", box.Volume);

            box.DisplayInfo();

            Console.WriteLine(box.FrontSurface);
            Console.ReadKey();
        }

    }
}
