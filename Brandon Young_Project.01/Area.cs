using System;
using System.Collections.Generic;
using System.Text;

namespace Brandon_Young_Project._01
{
    class Area
    {
        public static double Triangle(double varOne, double varTwo)
        {
            return ((varOne * varTwo) / 2);
        }

        public static double Rectangle(double varOne, double varTwo)
        {
            return (varOne * varTwo);
        }

        public static double Square(double varOne)
        {
            return (varOne * varOne);
        }

        public static double Circle(double varOne)
        {
            return (Math.PI * (varOne * varOne));
        }
    }
}