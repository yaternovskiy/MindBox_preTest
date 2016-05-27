using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MindBox_preTest
{
    public class Calculator
    {
        private const float AllowedDeviation = 0.01F;

        static void Main(string[] args)
        {
        }

        static public double TriangleArea3Sides(params double[] args)
        {
            Array.Sort(args);

            if (!IsValidTriangle(args)) {
                Console.Write("Invalid parameters for TriangleArea3Sides. 3 sides' lengths are needed.");
                return 0;
            };
            
            return args[0] * args[1] / 2;
        }

        // Следующий метод я бы сделал приватным и юнит-тесты для него не делал бы, но здесь сделаю публичным...

        static public bool IsValidTriangle(double[] args) // checks if valid lengths of triangle's sides are given
        {
            if (args.Length != 3) return false;     // total 3 values accepted

            foreach (double value in args)          // positive values accepted
            {
                if (value <= 0) return false;
            }

            // Pifagor's theorem check with given allowed deviation
            if (Math.Abs((Math.Pow(args[2], 2) / (Math.Pow(args[0], 2) + Math.Pow(args[1], 2)) - 1)) > AllowedDeviation)
                return false;
            else return true;

        }
    }
}
