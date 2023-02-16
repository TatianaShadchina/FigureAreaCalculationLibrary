using System;
using FigureAreaCalculationLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestApp
{
    [TestClass]
    public class UnitTestTriangle
    {
        //Тест метода рассчета площади треугольника
        [TestMethod]
        public void TestTriangleCalcArea()
        {
            Triangle triangle = new Triangle();

            double sideA = 1;
            double sideB = 2;
            double sideC = 3;

            var halfPerimeter = (sideA + sideB + sideC) / 2;
            var expectedValue = Math.Sqrt(halfPerimeter * (halfPerimeter - sideA) * (halfPerimeter - sideB) * (halfPerimeter - sideC));

            double result = triangle.TriangleAreaCalculation(sideA, sideB, sideC);

            Assert.AreEqual(expectedValue, result);
        }

        //Тест метода является ли треугольник прямоугольным
        [TestMethod]
        public void TestIsRightTriangle()
        {
            Triangle triangle = new Triangle();

            double sideA = 24;
            double sideB = 10;
            double sideC = 26;

            var expectedValue = true;

            bool result = triangle.IsRightTriangle(sideA, sideB, sideC);

            Assert.AreEqual(expectedValue, result);
        }
    }
}
