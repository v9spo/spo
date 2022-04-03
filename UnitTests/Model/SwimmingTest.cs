using System;

using Model;
using NUnit.Framework;

namespace UnitTests.Model
{
    /// <summary>
    /// Тестовый набор для класса Swimming.
    /// </summary>
    [TestFixture]
    public class SwimmingTest
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
            Assert.AreEqual("Плавание",
                new Swimming(SwimmingEnum.Crawl, 1)
                .PhysicalExerciseName);
            Assert.AreEqual("Плавание",
                new Swimming(SwimmingEnum.Breaststroke, 75)
                .PhysicalExerciseName);
            Assert.AreEqual("Плавание",
                new Swimming(SwimmingEnum.Butterfly, 149)
                .PhysicalExerciseName);
        }

        /// <summary>
        /// Тестирование свойства NumberCaloriesSpend.
        /// (положительное тестирование).
        /// </summary>
        /// <param name="swimmingStyle">Стиль плавания.</param>
        /// <param name="distance">Преодолённое расстояние.</param>
        [Test]
        [TestCase(SwimmingEnum.Crawl, Swimming.minValue + 0.001,
            TestName = "Tест количества затраченных калорий" +
            " при плавании при минимальном значении" +
            " преодолённого расстояния.")]

        [TestCase(SwimmingEnum.Breaststroke, 
            Swimming.maxDistance - 0.001,
            TestName = "Tест количества затраченных калорий" +
            " при плавании при максималььном значении" +
            " преодолённого расстояния.")]

        [TestCase(SwimmingEnum.Butterfly, 
            Swimming.minValue + 1,
            TestName = "Tест количества затраченных калорий" +
            " при плавании при максималььном значении " +
            "преодолённого расстояния + 1.")]

        [TestCase(SwimmingEnum.Butterfly, Swimming.maxDistance - 1,
            TestName = "Tест количества затраченных калорий" +
            " при плавании при максимальном значении" +
            " преодолённого расстояния - 1.")]

        [TestCase(SwimmingEnum.Breaststroke, 75,
            TestName = "Tест количества затраченных калорий" +
            " при плавании при средних значениях.")]
        public void TestPosetivNumberCaloriesSpend(SwimmingEnum
            swimmingStyle, double distance)
        {
            Swimming swimming = new Swimming(swimmingStyle,
                distance);

            double swimmingIntensity = 0;

            switch (swimmingStyle)
            {
                case SwimmingEnum.Crawl:
                    swimmingIntensity = 0.3;
                    break;
                case SwimmingEnum.Breaststroke:
                    swimmingIntensity = 0.2;
                    break;
                case SwimmingEnum.Butterfly:
                    swimmingIntensity = 0.1;
                    break;
            }

            Assert.True(swimming.NumberCaloriesSpend 
                == distance * swimmingIntensity * 2.9);
        }

        /// <summary>
        /// Тестирование свойства NumberCaloriesSpend.
        ///(негативное тестирование).
        /// </summary>
        /// <param name="swimmingStyle">Стиль плавания.</param>
        /// <param name="distance">Преодолённое расстояние.</param>
        [Test]
        [TestCase(SwimmingEnum.Crawl, Swimming.maxDistance + 1,
            TestName = "Tест количества затраченных калорий" +
            " при плавании при недопустимо малом значении" +
            " преодолённого расстояния + 1 .")]

        [TestCase(SwimmingEnum.Crawl, Swimming.minValue,
            TestName = "Tест количества затраченных калорий" +
            " при плавании при недопустимо малом значении" +
            " преодолённого расстояния.")]

        [TestCase(SwimmingEnum.Crawl, Swimming.maxDistance,
            TestName = "Tест количества затраченных калорий" +
            " при плавании при недопустимо большом значении" +
            " преодолённого расстояния.")]

        [TestCase(SwimmingEnum.Crawl, Swimming.minValue - 1,
            TestName = "Tест количества затраченных калорий" +
            " при плавании при недопустимо малом значении" +
            " преодолённого расстояния - 1.")]

        public void TestNegotiveNumberCaloriesSpend(SwimmingEnum
            swimmingStyle, double distance)
        {
            Assert.Throws<Exception>(delegate ()
            {
                Swimming swimming = new
                Swimming(swimmingStyle, distance);
            });
        }
    }
}