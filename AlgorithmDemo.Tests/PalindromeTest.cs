using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AlgorithmDemo.Libs.Helpers;

namespace AlgorithmDemo.Tests
{
    [TestClass]
    public class PalindromeTest
    {

        [TestMethod]
        public void Given_a_string_it_should_tell_if_that_string_is_Palindrome()
        {
            Assert.AreEqual(false, Palindrome.IsPalindrome("aaaba"));
            Assert.AreEqual(true, Palindrome.IsPalindrome("aabaa"));
            Assert.AreEqual(true, Palindrome.IsPalindrome("abcddcba"));
            Assert.AreEqual(true, Palindrome.IsPalindrome(""));
        }
    }
}
