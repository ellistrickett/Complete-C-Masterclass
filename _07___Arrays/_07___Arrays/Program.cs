using System;

namespace _07___Arrays
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // Declare 2D array
            string[,] matrix;

            //3D Array
            int[,,] threeD;

            // two dimensional array
            int[,] array2D = new int[,]
            {
                {1, 2, 3}, // row 0
                {2, 5, 6}, // row 1
                {7, 8, 9}  // row 2
            };

            string[,,] array3D = new string[,,]
            {
                {
                    {"000", "001"},
                    {"010", "011"}
                },
                {
                    {"100", "101"},
                    {"110", "111"}
                }
            };

            // Rank returns the amount of dimensions
            Console.WriteLine(array3D.Rank);

            Console.WriteLine("Central value is {0}", array3D[1, 1, 0]);
            Console.ReadKey();
        }
    }
}
