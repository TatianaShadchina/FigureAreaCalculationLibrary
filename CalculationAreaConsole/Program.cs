using FigureAreaCalculationLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CalculationAreaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            /*пример прямоугольного треугольника: 24 10 26*/
            Console.WriteLine("Чтоб рассчитать площадь фигуры, введите размерность сторон фигуры через пробел. Либо введите радиус:");
            var input = Console.ReadLine().Split();
            var list = new List<double>(input.Select(double.Parse));
            
            foreach(var i in list)
            {
                if (i <= 0)
                {
                    Console.WriteLine("Ошибка! Вы ввели отрицательное или равное нулю число");
                    return;
                }
            }
            double Area = 0;

            FigureEnum listCount = (FigureEnum)list.Count();

            switch (listCount)
            {
                case FigureEnum.Triangle:
                    Triangle t = new Triangle(list[0], list[1], list[2]);
                    Area = t.IsRightTriangle() == false ? t.TriangleAreaCalculation() : t.RightTriangleAreaCalculation();
                    break;

                case FigureEnum.Circle:
                    Circle c = new Circle(list[0]);
                    Area = c.CircleAreaCalculation();
                    break;

                default:
                    Console.WriteLine("Error");
                    break;
                    
            }
            Console.WriteLine(Area);
            Console.ReadLine();

        }
    }
}
