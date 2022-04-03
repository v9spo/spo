namespace Model
{
    /// <summary>
    /// Класс с информацией о физическом убоажнении - бег.
    /// </summary>
    public class Run : ExercisePhysicalBase
    {
        /// <summary>
        /// Константа - максимальная интенсивность бега.
        /// </summary>
        public const int maxIntensity = 100;

        /// <summary>
        /// Константа -максимальное преодолённая дистанция.
        /// </summary>
        public const int maxDistance = 100;

        /// <summary>
        /// Конструктор класса ExercisePhysicalBase.
        /// </summary>
        /// <param name="intensity">Интенсивность бега.</param>
        /// <param name="distance">Преодалённая дистанция.</param>
        public Run(double intensity, double distance)
        {
            Intensity = intensity;
            Distance = distance;
        }

        /// <summary>
        /// Поле - интенсивности бега.
        /// </summary>
        private double _intensity;

        /// <summary>
        /// Свойство - бега.
        /// </summary>
        private protected double Intensity
        {
            get => _intensity;
            set => _intensity = ValidationMethod("интенсивность" +
                " бега", value, minValue, maxIntensity);
        }

        /// <summary>
        /// Поле - преодолённое расстояние.
        /// </summary>
        private double _distance;

        /// <summary>
        /// Свойство - преодолённое расстояние.
        /// </summary>
        private protected double Distance
        {
            get => _distance;
            set => _distance = ValidationMethod("преодолённое" +
                " расстояние", value, minValue, maxDistance);
        }

        /// <summary>
        /// Свойство - название физического упражнения.
        /// </summary>
        public override string PhysicalExerciseName => "Бег";

        /// <summary>
        /// Свойство - количество затраченных калорий при беге.
        /// </summary>
        public override double NumberCaloriesSpend 
            => Distance * Intensity * 0.04;
    }
}