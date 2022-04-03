using System;

namespace Model
{
    /// <summary>
    /// Абстрактный класс для описания физических упражнений.
    /// </summary>
    public abstract class ExercisePhysicalBase
    {
        /// <summary>
        /// Свойство - название физического упражнения.
        /// </summary>
        public abstract string PhysicalExerciseName { get; }

        /// <summary>
        /// Свойство - количество затраченных калорий.
        /// </summary>
        public abstract double NumberCaloriesSpend { get; }

        /// <summary>
        /// Константа - минимальное значение параметра.
        /// </summary>
        public const int minValue = 0;

        /// <summary>
        /// Метод проверки введённых значений.
        /// </summary>
        /// <param name="nameParametr">Название параметра.</param>
        /// <param name="valueParametr">Значение параметра.</param>
        /// <param name="minValue">Минимальное 
        /// значение параметра.</param>
        /// <param name="maxValue">Максимальное 
        /// значение параметра.</param>
        /// <returns>Результат проверки параметра.</returns>
        public static double ValidationMethod(string nameParametr,
            double valueParametr, double minValue,
            double maxValue)
        {
            if ((valueParametr > minValue)
                && (valueParametr < maxValue))
            {
                return valueParametr;
            }
            else
            {
                throw new Exception($"Значение " +
                    $"параметра {nameParametr}" +
                    $" должно быть больше {minValue}" +
                    $" и меньше {maxValue}.");
            }
        }
    }
}