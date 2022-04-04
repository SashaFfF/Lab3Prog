using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab3._1;
using lab3._2;
using lab3._3;

namespace TestProjectLab3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int number = 20;
            int expectedResult = 10;

            int actualResult = Calc.Replacement(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int number = 21;
            int expectedResult = 0;

            int actualResult = Calc.Replacement(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double number = 0;
            double expectedResult = 1;

            double actualResult = CalcX.CalculateX(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod4()
        {
            double number = 2;
            double expectedResult = 0.125;

            double actualResult = CalcX.CalculateX(number);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string date = "05.04.2022";
            string expectedResult = "Tuesday";

            string actualResult = DateService.GetDay(date);

            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void TestMethod6()
        {
            int day = 4;
            int month = 4;
            int year = 2022;

            int expectedResult = 1;

            int actualResult = DateService.GetDaysSpan(day, month, year);

            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
