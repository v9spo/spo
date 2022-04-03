using System;

namespace View
{
    [Serializable]
    /// <summary>
    /// Класс с информацией
    /// о названии физического упражнения 
    /// и количестве затраченных калорий.
    /// </summary>
    public class PhysicalExercise
    {
        /// <summary>
        /// Свойство - название физического упражнения.
        /// </summary>
        public string ExerciseName { get; set; }

        /// <summary>
        /// Свойство - количество затраченных калорий.
        /// </summary>
        public double? CaloriesSpend { get; set; }
    }
}