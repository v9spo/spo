using System;
using System.Globalization;
using System.Threading;

using Model;

namespace ConsoleLoader
{
    /// <summary>
    /// Класс для демонстрации библиотеки Model.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Метод начала запуска программы.
        /// </summary>
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture =
                new CultureInfo("ru-RU");

            GetRun();
            GetBarbellBrench();
            GetSwimming();

            Console.ReadKey();
        }

        /// <summary>
        /// Метод измерения количества калорий при беге.
        /// </summary>
        private static void GetRun()
        {
            Console.WriteLine("Бег");

            string stringIntensity = "интенсивность";
            InstallParametr(stringIntensity, Run.maxIntensity);
            double intensity = Validate(stringIntensity,
                Run.maxIntensity);

            string stringDistance = "расстояние";
            InstallParametr(stringDistance, Run.maxDistance);
            double distance = Validate(stringDistance,
                Run.maxDistance);

            ExercisePhysicalBase runExercise =
                new Run(intensity, distance);

            WriteInfo(runExercise);
        }

        /// <summary>
        /// Метод измерения количества калорий при плавании.
        /// </summary>
        private static void GetSwimming()
        {
            Console.WriteLine("Плавание");

            string stringDistance = "расстояние";
            InstallParametr(stringDistance,
                Swimming.maxDistance);
            double distance = Validate(stringDistance,
                Swimming.maxDistance);

            SwimmingEnum swimmingEnum;
            do
            {
                try
                {
                    Console.WriteLine("Выберете стиль плавания. " +
                        "0 Кроль, 1 Брасс, 2 Баттерфляй");

                    int enumValue = Convert
                        .ToInt32(Console.ReadLine());

                    if (((enumValue) >= 0) && ((enumValue) <= 2))
                    {
                        swimmingEnum = (SwimmingEnum)enumValue;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Значение должно быть" +
                            " 0 1 или 2.");
                    }
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
            } while (true);

            ExercisePhysicalBase swimmingExercise =
                new Swimming(swimmingEnum, distance);

            WriteInfo(swimmingExercise);
        }

        /// <summary>
        /// Метод измерения количества калорий при жиме штанги.
        /// </summary>
        private static void GetBarbellBrench()
        {
            Console.WriteLine("Жим штанги");

            string stringWeigth = "вес штанги";
            InstallParametr(stringWeigth,
                BarbellBrench.maxWeigth);
            double weigth = Validate(stringWeigth,
                BarbellBrench.maxWeigth);

            string stringNumber = "количество повторений";
            InstallParametr(stringNumber,
                BarbellBrench.maxNumber);
            double numberRepetitions = Validate(stringNumber,
                BarbellBrench.maxNumber);

            ExercisePhysicalBase barbellBrenchExercise =
                new BarbellBrench(weigth, numberRepetitions);

            WriteInfo(barbellBrenchExercise);
        }

        /// <summary>
        /// Метод установки значения параметра.
        /// </summary>
        /// <param name="parametrName">Название параметра.</param>
        /// <param name="maxParametrValue">Максимальное 
        /// значение параметра.</param>
        private static void InstallParametr(string parametrName,
            int maxParametrValue)
        {
            Console.WriteLine($"Введите значение {parametrName}." +
                $" Значение {parametrName} должно быть больше" +
                $" {ExercisePhysicalBase.minValue}" +
                $" и меньше {maxParametrValue}:");
        }

        /// <summary>
        /// Метод проверки информации.
        /// </summary>
        /// <param name="parametrName">Название параметра.</param>
        /// <param name="maxParametrValue">Максимальное
        /// значение.</param>
        /// <returns>Результат проверки.</returns>
        private static double Validate(string parametrName,
            int maxParametrValue)
        {
            double validValue;
            do
            {
                try
                {
                    string parametrValue = Console.ReadLine()
                        .Replace(".", ",");
                    if (parametrValue.Contains(" "))
                    {
                        throw new Exception("Введено" +
                            " некорректное значение.");
                    }
                    validValue = Convert.ToDouble(parametrValue);
                    ExercisePhysicalBase
                        .ValidationMethod(parametrName, validValue,
                        ExercisePhysicalBase.minValue,
                        maxParametrValue);
                    Console.WriteLine($"Введено" +
                        $" значение: {validValue}.");
                    break;
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    InstallParametr(parametrName,
                        maxParametrValue);
                }
            } while (true);
            return validValue;
        }

        /// <summary>
        /// Метод вывода информации.
        /// </summary>
        /// <param name="exercisePhysical">Объект класса
        /// ExercisePhysicalBase</param>
        private static void WriteInfo(ExercisePhysicalBase
            exercisePhysical)
        {
            Console.WriteLine($"Название упражнения: " +
                $"{exercisePhysical.PhysicalExerciseName}");
            Console.WriteLine($"Количество затраченных калорий: " +
                $"{exercisePhysical.NumberCaloriesSpend}");
        }
    }
}