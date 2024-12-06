using Microsoft.VisualStudio.TestTools.UnitTesting;
using SolveArray.Lib;

namespace SolveArray.Test
{
    [TestClass]
    public class ValidArray
    {
        [TestMethod]
        public void TestCalculateMinimum()
        {
            var arr = new SolveArray.Lib.Array();
            int[] array = { 6, 4, 3, 5, 1 };
            double result = arr.CalculateMinimum(array);
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void TestCalculateMaximum()
        {
            var arr = new SolveArray.Lib.Array();
            int[] array = { 6, 4, 3, 5, 10 };
            double result = arr.CalculateMaximum(array);
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestCalculateAverage()
        {
            var arr = new SolveArray.Lib.Array();
            int[] array = { 6, 1, 3, 5, 10 };
            double result = arr.CalculateAverage(array);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestCalculateMedian()
        {
            var arr = new SolveArray.Lib.Array();
            int[] array = { 6, 1, 3, 5, 10 };
            double result = arr.CalculateMedian(array);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestCalculateNumberOfEven()
        {
            var arr = new SolveArray.Lib.Array();
            int[] array = { 6, 1, 3, 5, 10 };
            double result = arr.CalculateNumberOfEven(array);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestCalculateNumberOfOdd()
        {
            var arr = new SolveArray.Lib.Array();
            int[] array = { 6, 1, 3, 5, 10 };
            double result = arr.CalculateNumberOfOdd(array);
            Assert.AreEqual(3, result);
        }

        [TestMethod]
        public void TestSignsOfDivisibilityByTwo()
        {
            var arr = new SolveArray.Lib.Array();
            int[] array = { 6, 1, 3, 5, 10 };
            double result = arr.SignsOfDivisibilityByTwo(array);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestSignsOfDivisibilityByThree()
        {
            var arr = new SolveArray.Lib.Array();
            int[] array = { 6, 1, 3, 5, 10 };
            double result = arr.SignsOfDivisibilityByThree(array);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestSignsOfDivisibilityByFive()
        {
            var arr = new SolveArray.Lib.Array();
            int[] array = { 6, 1, 3, 5, 10 };
            double result = arr.SignsOfDivisibilityByFive(array);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestSignsOfDivisibilityByTen()
        {
            var arr = new SolveArray.Lib.Array();
            int[] array = { 6, 1, 3, 5, 10 };
            double result = arr.SignsOfDivisibilityByTen(array);
            Assert.AreEqual(1, result);
        }
    }
}