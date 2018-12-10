﻿using System;

namespace MathLibrary
{
    public class MathRoutines
    {
        public static decimal Add(decimal num1, decimal num2)
        {
            return Math.Round((num1 + num2), 2);
        }

        public static decimal Subtract(decimal num1, decimal num2)
        {
            return Math.Round((num1 - num2), 2);
        }

        public static decimal Multiply(decimal num1, decimal num2)
        {
            return Math.Round((num1 * num2), 2);
        }

        public static decimal Divide(decimal num1, decimal num2)
        {
            return Math.Round((num1 / num2), 2);
        }

        public static double Power(double num1, double num2)
        {
            return Math.Round((Math.Pow(num1, num2)), 2);
        }

        public static decimal Ceiling(decimal num1)
        {
            return Math.Round((Math.Ceiling(num1)), 2);
        }

        public static decimal Floor(decimal num1)
        {
            return Math.Round((Math.Floor(num1)), 2);
        }
    }
}
