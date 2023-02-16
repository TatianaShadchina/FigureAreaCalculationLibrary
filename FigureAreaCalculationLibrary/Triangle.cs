using System;

namespace FigureAreaCalculationLibrary
{
    public class Triangle : ITriangle
    {
        /// <summary>
        /// рассчет плащади треугольника по трем сторонам(для треугольника, который не является прямоугольным)
        /// </summary>
        /// <param name="halfPerimeter"></param>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public double TriangleAreaCalculation(double sideA, double sideB, double sideC)
        {
            //полупериметр
            var halfPerimeter = (sideA + sideB + sideC) / 2;

            //площадь
            var S = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

            return S;
        }

        /// <summary>
        /// проверка является ли треугольник прямоугольным. 
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public bool IsRightTriangle(double sideA, double sideB, double sideC)
        {
            if(!(sideA == sideB && sideA == sideC && sideB == sideC)/*если треугольник не является равносторонним*/
                /*По т.Пифагора квадрат гипотенузы равен сумме квадратов катетов*/
                && ( ((sideA*sideA + sideB*sideB) == sideC*sideC) /*Если сторона С является гипотенузой*/
                || ((sideA*sideA + sideC*sideC) == sideB*sideB) /*Если сторона В является гипотенузой*/
                || ((sideB*sideB + sideC*sideC) == sideA*sideA) )/*Если сторона А является гипотенузой*/
                )
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
