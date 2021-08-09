using LeetCodes1;
using NUnit.Framework;

namespace LeetCodes1Tests
{
    /// <summary>
    /// The good strings tests.
    /// </summary>
    public class GoodStringsTests
    {
        /// <summary>
        /// Tests the min to delete from string.
        /// </summary>
        /// <param name="testingString">The testing string.</param>
        /// <param name="assertingVal">The asserting val.</param>
        [Test]
        [TestCase("aab", 0)]
        [TestCase("aaabbbcc", 2)]
        [TestCase("ceabaacb", 2)]
        [TestCase("ceabaacbxxxxfffff", 2)]
        public void TestMinToDeleteFromString (string testingString, int assertingVal)
        {
            int returnd = GoodString.MinToDelete(testingString);
            Assert.AreEqual(assertingVal, returnd);
        }
    }
}