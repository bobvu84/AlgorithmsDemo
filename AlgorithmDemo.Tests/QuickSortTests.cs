using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmDemo.Helpers;

namespace AlgorithmDemo.Tests
{
    [TestClass]
    public class QuickSortTests
    {
        private int[] numbers = new int[] { 5, 4, 8, 7, 6 };
        private int[] sorted = new int[] { 4, 5, 6, 7, 8 };
        public QuickSortTests()
        {

        }
        [TestMethod]
        public void TestMethod1()
        {
            var sorter = new QuickSort();
            sorter.sort(numbers);
            Console.WriteLine(numbers);
            int vl = numbers[numbers.Length / 2];
            int val1 = numbers.Length / 2;
            Console.ReadLine();

        }
    }
}
