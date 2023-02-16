using System;
using FigureAreaCalculationLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestApp
{
    [TestClass]
    public class UnitTestCircle
    {
        //Тест метода рассчета площади круга
        [TestMethod]
        public void TestCircleCalcArea()
        {
            Circle circle = new Circle();

            double radius = 5;

            var expectedValue = Math.PI * Math.Pow(radius, 2);

            double result = circle.CircleAreaCalculation(radius);

            Assert.AreEqual(expectedValue, result);
        }
    }
}
