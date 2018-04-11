using System;
using Net.S._2018.Zenovich._11.BinarySearch;
using NUnit;
using NUnit.Framework;

namespace Net.S._2018.Zenovich._11.Tests
{
    [TestFixture]
    public class SearcherTest
    {
        [TestCase(new string[] { "b", "c", "d" }, "d", ExpectedResult = 2)]
        [TestCase(new string[] { "b", "c", "d" }, "b", ExpectedResult = 0)]
        [TestCase(new string[] { "b", "c", "d" }, "c", ExpectedResult = 1)]
        [TestCase(new string[] { "bb", "cc", "dd" }, "aa", ExpectedResult = -1)]
        [TestCase(new string[] { "b", "c", "d" }, "cd", ExpectedResult = -1)]
        [TestCase(new string[] { "b", "c", "d" }, "e", ExpectedResult = -1)]
        public int BinarySearchTest_InputStringArray(string[] array, string element)
        {
            return Searcher.BinarySearch<string>(array, element);
        }

        [Test]
        public void BinarySearchTest_NullIntArray_ArgumentNullException()
        {
            int[] array = null;
            int element = -22;
            Assert.Throws<ArgumentNullException>(() => Searcher.BinarySearch<int>(array, element));
        }

        [Test]
        public void BinarySearchTest_InputNullStringArray_ArgumentNullException()
        {
            string[] array = null;
            string element = "Hello, world!";
            Assert.Throws<ArgumentNullException>(() => Searcher.BinarySearch<string>(array, element));
        }

        [TestCase(new int[] { 1, 2, 3, 7, 9, 100 }, 7, ExpectedResult = 3)]
        [TestCase(new int[] { 4, 11, 15, 23, 30 }, 4, ExpectedResult = 0)]
        [TestCase(new int[] { 15, 32, 33, 111, 1112 }, 11, ExpectedResult = -1)]
        [TestCase(new int[] { 4, 33, 122, 232, 442 }, 33, ExpectedResult = 1)]
        [TestCase(new int[] { 4, 11, 12, 23, 44 }, 45, ExpectedResult = -1)]
        [TestCase(new int[] { 4, 7, 12, 15, 55, 66, 77, 88 }, 88, ExpectedResult = 7)]
        public int BinarySearchTest_InputIntArray(int[] array, int element)
        {
            return Searcher.BinarySearch<int>(array, element);
        }
    }
}
