using System;
using System.Collections.Generic;
using System.Text;

namespace FigureAreaCalculationLibrary
{
    public interface ITriangle
    {
        /// <summary>
        /// проверка является ли треугольник прямоугольным.
        /// </summary>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        bool IsRightTriangle();

        /// <summary>
        /// рассчет площади треугольника по трем сторонам(для треугольника, который не является прямоугольным)
        /// </summary>
        /// <param name="halfPerimeter"></param>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        double TriangleAreaCalculation();

        /// <summary>
        /// рассчет площади прямоугольного треугольника по трем сторонам
        /// </summary>
        /// <returns></returns>
        double RightTriangleAreaCalculation();
    }
}
