using System;
using System.Collections.Generic;
using System.Text;

namespace FigureAreaCalculationLibrary
{
    public class Circle : ICircle
    {
        //радиус круга
        double Radius { get; set; }

        public Circle(double r)
        {
            Radius = r;
        }

        /// <summary>
        /// рассчет площади круга по радиусу
        /// </summary>
        /// <returns></returns>
        public double CircleAreaCalculation()
        {
            var S = Math.PI * Radius * Radius;
            return S;
        }
    }
}
