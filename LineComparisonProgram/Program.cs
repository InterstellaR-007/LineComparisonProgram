using System;
using System.Runtime.ConstrainedExecution;

namespace LineComparisonProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Program on Master Branch");
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
        public static int LengthOfLine(int x1, int y1, int x2, int y2)
        {
            int lengthOfLine;
            lengthOfLine = (int)Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            ////Math.Pow((x1 - x2), 2) +Math.Pow((y1-y2),2)
            return lengthOfLine;

        }
    }
}
