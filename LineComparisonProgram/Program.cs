using System;
using System.Runtime.ConstrainedExecution;

namespace LineComparisonProgram
{
    /// <summary>
    /// Program to showcase the two line comparison based on length
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Program on Master Branch");
            int[] x = new int[4];
            int[] y = new int[4];
            for (int i = 0; i < 3; i=i+2)
            {
                Console.WriteLine("Enter the X and Y coordinates for Line" + (i + 1));
                x[i] = Convert.ToInt32(Console.ReadLine());
                y[i] = Convert.ToInt32(Console.ReadLine());
                x[i+1] = Convert.ToInt32(Console.ReadLine());
                y[i+1] = Convert.ToInt32(Console.ReadLine());
            }

            Double lineLenght_1 = LengthOfLine(x[0], y[0], x[1], y[1]);
            Double lineLenght_2 = LengthOfLine(x[2], y[2], x[3], y[3]);

            Console.WriteLine("The length of Line1 is : " + lineLenght_1);
            Console.WriteLine("The length of Line2 is : " + lineLenght_2);
            if (EqualLength(lineLenght_1, lineLenght_2) == true)
            {
                Console.WriteLine("Both Lines are equal in Length");
            }
            else
            {
                Console.WriteLine("Both Lines are Unequal in Length");
            }
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
            ////Math.Pow((x1 - x2), 2) +Math.Pow((y1-y2),2)
            return lengthOfLine;

        }
        /// <summary>
        /// Whether Line are Equal in length
        /// </summary>
        /// <param name="l1">The l1.</param>
        /// <param name="l2">The l2.</param>
        /// <returns></returns>
        public static Boolean EqualLength(Double l1,Double l2)
        {
            if (l1.CompareTo(l2) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
