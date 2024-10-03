﻿using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.GalimovaAS.Sprint1.Task7.V14.Lib
{
    public class DataService : ISprint1Task7V14
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Round(Math.Pow(2, -x) + (5 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 2)) - Math.Cos(Math.Pow(x, 2)) + Math.Sin(2 * x * y), 3);
            return res;
        }
    }
    
}
