namespace Model
{
    /// <summary>
    /// Класс с информацией о жиме штанги.
    /// </summary>
    public class BarbellBrench : ExercisePhysicalBase
    {
        /// <summary>
        /// Константа - максимальный вес штанги.
        /// </summary>
        public const int maxWeigth = 300;

        /// <summary>
        /// Константа - максимальное количество повторов.
        /// </summary>
        public const int maxNumber = 400;

        /// <summary>
        /// Конструктор класса BarbellBrench.
        /// </summary>
        /// <param name="weigth">Вес штанги.</param>
        /// <param name="numberRepetitions">Количество
        /// повторов.</param>
        public BarbellBrench(double weigth,
            double numberRepetitions)
        {
            Weigth = weigth;
            Number = numberRepetitions;
        }

        /// <summary>
        /// Поле - вес штанги.
        /// </summary>
        private double _weigth;

        /// <summary>
        /// Свойство - вес штанги.
        /// </summary>
        private protected double Weigth
        {
            get => _weigth;
            set => _weigth = ValidationMethod("вес штанги",
                value, minValue, maxWeigth);
        }

        /// <summary>
        /// Поле - количество повторов.
        /// </summary>
        private double _number;

        /// <summary>
        /// Свойство - количество повторов.</summary>
        private protected double Number
        {
            get => _number;
            set => _number = ValidationMethod("количество" +
                " повторов", value, minValue, maxNumber);
        }

        /// <summary>
        /// Свойство - названии физического упражнения.
        /// </summary>
        public override string PhysicalExerciseName 
            => "Жим штанги";

        /// <summary>
        /// Свойство - количество затраченных калорий
        /// при жиме штанги.
        /// </summary>
        public override double NumberCaloriesSpend 
            => Weigth * Number * 0.05;
    }
}