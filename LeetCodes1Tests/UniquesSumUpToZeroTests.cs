using LeetCodes1;
using NUnit.Framework;
using System.Linq;

namespace LeetCodes1Tests
{
    /// <summary>
    /// The good strings tests.
    /// </summary>
    public class UniquesSumUpToZeroTests
    {
        /// <summary>
        /// Tests the min to delete from string.
        /// </summary>
        /// <param name="testingString">The testing string.</param>
        /// <param name="assertingVal">The asserting val.</param>
        [Test]
        [TestCase(1, 1)]
        [TestCase(3, 3)]
        [TestCase(5, 5)]
        [TestCase(8, 8)]
        [TestCase(100, 100)]
        //[TestCase(1005,1005)]
        public void TestUniquesSumUpToZero (int reqLength, int assertingVal)
        {
            int[] returnd = FindNUniqueIntegersSumuptoZero.GetVs(reqLength);
            Assert.AreEqual(assertingVal, returnd.Length);
            Assert.AreEqual(0, returnd.ToList().Sum());
        }
    }
}