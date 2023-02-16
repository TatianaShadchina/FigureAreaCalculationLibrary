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
        bool IsRightTriangle(double sideA, double sideB, double sideC);

        /// <summary>
        /// рассчет площади треугольника по трем сторонам(для треугольника, который не является прямоугольным)
        /// </summary>
        /// <param name="halfPerimeter"></param>
        /// <param name="sideA"></param>
        /// <param name="sideB"></param>
        /// <param name="sideC"></param>
        /// <returns></returns>
        double TriangleAreaCalculation(double sideA, double sideB, double sideC);
    }
}
