using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmDemo.Libs.Helpers;
using AlgorithmDemo.Helpers;

namespace AlgorithmDemo.Tests
{
    [TestClass]
    public class SortedSearchTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var test = (2 + 3) / 2;
            var test1 = (0 + 3) / 2;
            var test2 = (0 + 1) / 2;
            Assert.AreEqual(3, SortedSearch.CountNumbers(new int[] { 1, 3, 5, 7, 8, 10, 12, 7 }, 6));
            Assert.AreEqual(1, SortedSearch.CountNumbers(new int[] { 1, 3}, 2));
            Assert.AreEqual(1, SortedSearch.CountNumbers(new int[] { 1 }, 2));
            Assert.AreEqual(0, SortedSearch.CountNumbers(new int[] { 1 }, -1));
        }
    }
}
