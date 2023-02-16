using FigureAreaCalculationLibrary;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace CalculationAreaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // внедрение зависимостей
            var services = new ServiceCollection();
            services.AddSingleton<ICalculator, Calculator>();
            services.AddSingleton<ITriangle, Triangle>();
            services.AddSingleton<ICircle, Circle>();

            var provider = services.BuildServiceProvider();
            var calculator = provider.GetService<ICalculator>();
            //

            //ввод значений
            while (true)
            {
                var figure = FigureEnum.Uknow;
                while (true)
                {
                    Console.WriteLine("Чтоб рассчитать площадь фигуры, введите тип фигуры: Circle или Triangle:");
                    var line = Console.ReadLine();
                    var inputFlag = Enum.TryParse<FigureEnum>(line, out figure);
                    if (inputFlag)
                    {
                        break;
                    }
                }

                // расчёт площади
                var area = 0d;
                var calcParams = Array.Empty<double>();
                switch (figure)
                {
                    case FigureEnum.Triangle:
                        while (true)
                        {
                            Console.WriteLine("Введите длины сторон треугольника:");
                            calcParams = Console.ReadLine().Split().Select(x => double.TryParse(x, out var d) ? d : 0).ToArray();
                            if (calcParams.Length == 3)
                            {
                                break;
                            }
                        }
                        area = calculator.TriangleAreaCalculation(calcParams[0], calcParams[1], calcParams[2]);
                        break;

                    case FigureEnum.Circle:
                        Console.WriteLine("Введите радиус круга:");
                        while (true)
                        {
                            calcParams = Console.ReadLine().Split().Select(x => double.TryParse(x, out var d) ? d : 0).ToArray();
                            if (calcParams.Length == 1)
                            {
                                break;
                            }
                        }
                        area = calculator.CircleAreaCalculation(calcParams[0]);
                        break;

                    default:
                        Console.WriteLine("Error");
                        break;
                }

                Console.WriteLine(area);
                Console.WriteLine();
                Console.WriteLine("Чтобы продолжить, нажмите любую квлавишу. Для выхода из приложения наберите exit");
                var e = Console.ReadLine();

                if(e == "exit")
                {
                    break;
                }
            }
        }
    }
}
