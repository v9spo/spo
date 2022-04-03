using System;

using Model;
using NUnit.Framework;

namespace UnitTests.Model
{
    /// <summary>
    /// Тестовый набор для класса Run.
    /// </summary>
    [TestFixture]
    public class RunTest
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
            Assert.AreEqual("Бег",
                new Run(1, 1).PhysicalExerciseName);
            Assert.AreEqual("Бег",
                new Run(50, 50).PhysicalExerciseName);
            Assert.AreEqual("Бег",
                new Run(99, 99).PhysicalExerciseName);
        }

        /// <summary>
        /// Тестирование свойства NumberCaloriesSpend.
        /// (положительное тестирование).
        /// </summary>
        /// <param name="intensity">Интенсивность бега.</param>
        /// <param name="distance">Преодолённая дистанция.</param>
        [Test]
        [TestCase(Run.minValue + 0.001
            , Run.minValue + 0.001,
            TestName = "Tест количества затраченных калорий" +
            " при беге при минимальном значении интенсивности" +
            " и дистанции.")]

        [TestCase(Run.maxIntensity - 0.001,
            Run.maxDistance - 0.001,
            TestName = "Tест количества затраченных калорий" +
            " при беге при максималььном значении интенсивности" +
            " и дистанции.")]

        [TestCase(Run.minValue + 1,
            Run.minValue + 1,
            TestName = "Tест количества затраченных калорий" +
            " при беге при минимальном значении интенсивности" +
            " + 1 и дистанции + 1.")]

        [TestCase(Run.maxIntensity - 1,
            Run.maxDistance - 1,
            TestName = "Tест количества затраченных калорий" +
            " при беге при максималььном значении интенсивности" +
            " - 1 и дистанции - 1.")]

        [TestCase(50, 50,
            TestName = "Tест количества затраченных калорий" +
            " при беге при средних значениях.")]
        public void TestPosetivNumberCaloriesSpend(double
            intensity, double distance)
        {
            Run run = new Run(intensity, distance);

            Assert.True(run.NumberCaloriesSpend 
                == intensity * distance * 0.04);
        }

        /// <summary>
        /// Тестирование свойства NumberCaloriesSpend.
        ///(негативное тестирование).
        /// </summary>
        /// <param name="intensity">Интенсивность бега.</param>
        /// <param name="distance">Преодалённая дистанция.</param>
        [Test]
        [TestCase(Run.minValue, Run.minValue + 1,
            TestName = "Tест количества затраченных калорий" +
            " при беге при недопустимо малом значении" +
            " интенсивности.")]

        [TestCase(Run.minValue + 1, Run.minValue,
            TestName = "Tест количества затраченных калорий" +
            " при беге при недопустимо малом значении дистанции.")]

        [TestCase(Run.maxIntensity,
            Run.maxDistance - 1,
            TestName = "Tест количества затраченных калорий" +
            " при беге при недопустимо большом значении" +
            " интенсивности.")]

        [TestCase(Run.maxIntensity - 1,
            Run.maxDistance,
            TestName = "Tест количества затраченных калорий" +
            " при беге при недопустимо большом" +
            " значении дистанции.")]

        [TestCase(Run.maxIntensity,
            Run.maxDistance,
            TestName = "Tест количества затраченных калорий" +
            " при беге при недопустимо большом значении" +
            " интенсивности и дистанции.")]

        [TestCase(Run.minValue, Run.minValue,
            TestName = "Tест количества затраченных калорий" +
            " при беге при недопустимо малом значении" +
            " интенсивности и дистанции.")]

        public void TestNegotiveNumberCaloriesSpend(double
            intensity, double distance)
        {
            Assert.Throws<Exception>(delegate ()
            {
                Run run = new
                Run(intensity, distance);
            });
        }
    }
}