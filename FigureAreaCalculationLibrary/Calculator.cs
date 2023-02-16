namespace FigureAreaCalculationLibrary
{
    public class Calculator : ICalculator
    {
        private readonly ITriangle triangle;
        private readonly ICircle circle;

        public Calculator(ITriangle triangle, ICircle circle)
        {
            this.triangle = triangle;
            this.circle = circle;
        }

        public double CircleAreaCalculation(double radius)
        {
            return circle.CircleAreaCalculation(radius);
        }

        public double TriangleAreaCalculation(double sideA, double sideB, double sideC)
        {
            return triangle.TriangleAreaCalculation(sideA, sideB, sideC);
        }

        public bool IsRightTriangle(double sideA, double sideB, double sideC)
        {
            return triangle.IsRightTriangle(sideA, sideB, sideC);
        }
    }
}
