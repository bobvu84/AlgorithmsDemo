using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmDemo.Libs.Helpers;

namespace AlgorithmDemo.Tests
{
    /// <summary>
    /// Summary description for BinarySearchTest
    /// </summary>
    [TestClass]
    public class BinarySearchTest
    {
        private Node n1, n2, n3,  n4, n5, n6, n7, n8, n9;
        public BinarySearchTest()
        {
            //
            // TODO: Add constructor logic here
            //
            n9 = new Node(13, null, null);
            n8 = new Node(14, n9, null);
            n7 = new Node(10, null, n8);
            n6 = new Node(7, null, null);
            n5 = new Node(4, null, null);
            n4 = new Node(6, n6, n4);
            n3 = new Node(1, null, null);
            n2 = new Node(3, n3, n4);
            n1 = new Node(8, n2, n7);

        }

       

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void It_should_tell_if_the_BST_contain_a_value_or_not()
        {
            //
            // TODO: Add test logic here
            //
            Assert.AreEqual(true, BinarySearchTree.Contains(n1, 14));
            Assert.AreEqual(false, BinarySearchTree.Contains(n1, 11));
            Assert.AreEqual(true, BinarySearchTree.Contains(n1, 3));
        }
    }
}
