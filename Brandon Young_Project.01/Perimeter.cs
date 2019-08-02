using System;
using System.Collections.Generic;
using System.Text;

namespace Brandon_Young_Project._01
{
    class Perimeter { 
   public static double Triangle(double varOne, double varTwo, double varThree)
    {
        return (varOne + varTwo + varThree);
    }

    public static double Rectangle(double varOne, double varTwo)
    {
        return ((varOne * 2) + (varTwo * 2));
    }

    public static double Square(double varOne)
    {
        return varOne * 4;
    }

    public static double Circle(double varTwo)
    {
        return (Math.PI * varTwo);
    }
}
}