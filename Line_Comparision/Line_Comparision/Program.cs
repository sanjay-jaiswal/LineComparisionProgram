using System;

namespace Line_Comparision
{
    class Program
    {
        /// <summary>
        /// Calculate length of a line
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("********Welcome to Line Comparision Program**********");

                double x1, y1, x2, y2;
                Console.WriteLine("Enter the cordinates (x1,y1) :");
                x1 = Convert.ToInt32(Console.ReadLine());
                y1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the cordinates (x2,y2) :");
                x2 = Convert.ToInt32(Console.ReadLine());
                y2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(calculateDistance(x1, y1, x2, y2));
            }
            //Function to calculate the length of a line
            private static double calculateDistance(double x1, double y1, double x2, double y2)
            {
                return (double)Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            }
    }
 }