using System;

namespace FigureAreaCalculationLibrary
{
    public class Circle : ICircle
    {
        /// <summary>
        /// Рассчет площади круга по радиусу
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public double CircleAreaCalculation(double radius)
        {
            var S = Math.PI * radius * radius;
            return S;
        }
    }
}
