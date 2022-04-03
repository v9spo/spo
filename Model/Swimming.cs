namespace Model
{
    /// <summary>
    /// Класс с информацией о плавании.
    /// </summary>
    public class Swimming : ExercisePhysicalBase
    {
        /// <summary>
        /// Константа - максимальное расстояние.
        /// </summary>
        public const int maxDistance = 150;

        /// <summary>
        /// Конструктор класса Swimming.
        /// </summary>
        /// <param name="swimmingStyle">Стиль плавания.</param>
        /// <param name="distance">Преодолённое расстояние.</param>
        public Swimming(SwimmingEnum swimmingStyle,
            double distance)
        {
            switch (swimmingStyle)
            {
                case SwimmingEnum.Crawl:
                    SwimmingIntensity = 0.3;
                    break;
                case SwimmingEnum.Breaststroke:
                    SwimmingIntensity = 0.2;
                    break;
                case SwimmingEnum.Butterfly:
                    SwimmingIntensity = 0.1;
                    break;
            }
            Distance = distance;
        }

        /// <summary>
        /// Свойство - интенсивность плавания.
        /// </summary>
        private double SwimmingIntensity { get; }

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
                " расстояние",
                value, minValue, maxDistance);
        }

        /// <summary>
        ///  Свойство - названии физического упражнения.
        /// </summary>
        public override string PhysicalExerciseName => "Плавание";

        /// <summary>
        /// Свойство - количество затраченных калорий при плавании.
        /// </summary>
        public override double NumberCaloriesSpend => Distance *
            SwimmingIntensity * 2.9;
    }
}