using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmDemo.Helpers;

namespace AlgorithmDemo.Tests
{
    [TestClass]
    public class TrainCompositionTests
    {
        private TrainComposition tree;
        public TrainCompositionTests()
        {
            tree = new TrainComposition();
            tree.AttachWagonFromLeft(7);
            tree.AttachWagonFromLeft(13);
            tree.AttachWagonFromRight(20);
            tree.AttachWagonFromLeft(18);
        }
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(20, tree.DetachWagonFromRight());
            Assert.AreEqual(7, tree.DetachWagonFromRight());
            Assert.AreEqual(18, tree.DetachWagonFromLeft());
            Assert.AreEqual(13, tree.DetachWagonFromLeft());

            //Assert.AreEqual(20, tree.DetachWagonFromRight());
        }
    }
}
