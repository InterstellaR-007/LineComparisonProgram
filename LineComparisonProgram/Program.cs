using System;
using System.Runtime.ConstrainedExecution;

namespace LineComparisonProgram
{
    /// <summary>
    /// Program to showcase Calculation of line lenght based on input coordinates
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            int[] x = new int[2];
            int[] y = new int[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Enter the X and Y coordinate for Line" + (i + 1));
                x[i] = Convert.ToInt32(Console.ReadLine());
                y[i] = Convert.ToInt32(Console.ReadLine());


            }

            Double v = LengthOfLine(x[0], y[0], x[1], y[1]);
            Console.WriteLine("The length of Line is : " + v);

        }
        /// <summary>
        /// Length the of line.
        /// </summary>
        /// <param name="x1">The x1.</param>
        /// <param name="y1">The y1.</param>
        /// <param name="x2">The x2.</param>
        /// <param name="y2">The y2.</param>
        /// <returns></returns>
        public static int LengthOfLine(int x1, int y1, int x2, int y2)
        {
            int lengthOfLine;
            lengthOfLine = (int)Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            return lengthOfLine;

        }
    }
}
