using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FigureAreaCalculationLibrary
{
    public class Triangle : ITriangle
    {
        double sideA { get; set; } 
        double sideB { get; set; }
        double sideC { get; set; }

        public Triangle(double A, double B, double C)
        {
            sideA = A;
            sideB = B;
            sideC = C;
        }


        /// <summary>
        /// рассчет плащади треугольника по трем сторонам(для треугольника, который не является прямоугольным)
        /// </summary>
        /// <param name="halfPerimeter"></param>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public double TriangleAreaCalculation()
        {
            //полупериметр
            var halfPerimeter = (sideA + sideB + sideC) / 2;

            //площадь
            var S = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

            return S;
        }

        /// <summary>
        /// рассчет площади прямоугольного треугольника по трем сторонам
        /// </summary>
        /// <returns></returns>
        public double RightTriangleAreaCalculation()
        {
            
            var S = 0d;
            if((Math.Pow(sideA,2) + Math.Pow(sideB,2)) == Math.Pow(sideC,2))
            {
                S = (sideA * sideB) / 2;
                return S;
            }
            if (((sideA * sideA + sideC * sideC) == sideB * sideB))
            {
                S = (sideA * sideC) / 2;
            }
            if(((sideB * sideB + sideC * sideC) == sideA * sideA))
            {
                S = (sideB * sideC) / 2;
            }
            return S;
        }

        /// <summary>
        /// проверка является ли треугольник прямоугольным. 
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        public bool IsRightTriangle()
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
