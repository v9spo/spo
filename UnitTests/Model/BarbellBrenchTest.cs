using System;

using Model;
using NUnit.Framework;

namespace UnitTests.Model
{
    /// <summary>
    /// Тестовый набор для класса BarbellBrench.
    /// </summary>
    [TestFixture]
    public class BarbellBrenchTest
    {
        /// <summary>
        /// Тестирование свойства PhysicalExerciseName.
        /// </summary>
        [Test(Description = "Тестирование свойства" +
            " PhysicalExerciseName")]
        [TestCase(TestName = "Тестирование свойства" +
            " PhysicalExerciseName")]
        public void TestName()
        {
            Assert.AreEqual("Жим штанги",
                new BarbellBrench(1, 1).PhysicalExerciseName);
            Assert.AreEqual("Жим штанги",
                new BarbellBrench(150,  200).PhysicalExerciseName);
            Assert.AreEqual("Жим штанги",
                new BarbellBrench(299, 399).PhysicalExerciseName);
        }

        /// <summary>
        /// Тестирование свойства NumberCaloriesSpend.
        /// (положительное тестирование).
        /// </summary>
        /// <param name="weigth">Вес штанги.</param>
        /// <param name="numberRepetitions">Количество
        /// повторов.</param>
        [Test]
        [TestCase(BarbellBrench.minValue + 0.001
            , BarbellBrench.minValue + 0.001,
            TestName = "Tест количества затраченных калорий" +
            " при жиме штанги" +
            " при минимальном значении веса штанги и" +
            " количестве повторов.")]

        [TestCase(BarbellBrench.maxWeigth - 0.001,
            BarbellBrench.maxNumber - 0.001,
            TestName = "Tест количества затраченных калорий при" +
            " жиме штанги" +
            " при максималььном значении веса штанги и" +
            " количестве повторов.")]

        [TestCase(BarbellBrench.minValue + 1,
            BarbellBrench.minValue + 1,
            TestName = "Tест количества затраченных калорий при" +
            " жиме штанги" +
            " при минимальном значении веса штанги + 1 и " +
            "количестве повторов + 1.")]

        [TestCase(BarbellBrench.maxWeigth - 1,
            BarbellBrench.maxNumber - 1,
            TestName = "Tест количества затраченных калорий при" +
            " жиме штанги" +
            " при максимальном значении веса штанги - 1 и " +
            "количестве повторов - 1.")]

        [TestCase(150, 200,
            TestName = "Tест количества затраченных калорий" +
            " при жиме штанги" +
            " при средних значениях.")]
        public void TestPosetivNumberCaloriesSpend(double weigth,
            double numberRepetitions)
        {
            BarbellBrench barbellBrench = new BarbellBrench(weigth,
                numberRepetitions);

            Assert.True(barbellBrench.NumberCaloriesSpend == weigth
                * numberRepetitions * 0.05);
        }

        /// <summary>
        /// Тестирование свойства NumberCaloriesSpend.
        ///(негативное тестирование).
        /// </summary>
        /// <param name="weigth">Вес штанги.</param>
        /// <param name="numberRepetitions">Количество
        /// повторов.</param>
        [Test]
        [TestCase(BarbellBrench.minValue, 
            BarbellBrench.minValue + 1,
            TestName = "Tест количества затраченных" +
            " калорий при жиме штанги при недопустимо малом" +
            " значении веса штанги.")]

        [TestCase(BarbellBrench.minValue + 1,
            BarbellBrench.minValue,
            TestName = "Tест количества затраченных калорий" +
            " при жиме штанги при недопустимо малом значении" +
            " количества повторов.")]

        [TestCase(BarbellBrench.maxWeigth,
            BarbellBrench.maxNumber - 1,
            TestName = "Tест количества затраченных калорий" +
            " при жиме штанги при недопустимо большом значении" +
            " веса штанги.")]

        [TestCase(BarbellBrench.maxWeigth - 1,
            BarbellBrench.maxNumber,
            TestName = "Tест количества затраченных калорий" +
            " при жиме штанги при недопустимо большом значении" +
            " количества повторов.")]

        [TestCase(BarbellBrench.maxWeigth,
            BarbellBrench.maxNumber,
            TestName = "Tест количества затраченных калорий" +
            " при жиме штанги при недопустимо большом значении" +
            " веса штанги и количества повторов.")]

        [TestCase(BarbellBrench.minValue, BarbellBrench.minValue,
            TestName = "Tест количества затраченных калорий при" +
            " жиме штанги при недопустимо малом значении веса" +
            " штанги и количества повторов.")]
        public void TestNegotiveNumberCaloriesSpend(double weigth,
            double numberRepetitions)
        {
            Assert.Throws<Exception>(delegate ()
            {
                BarbellBrench barbellBrench = new
                BarbellBrench(weigth, numberRepetitions);
            });
        }
    }
}