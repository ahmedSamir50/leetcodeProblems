using LeetCodes1;
using NUnit.Framework;

namespace LeetCodes1Tests
{
    /// <summary>
    /// The min steps to e q pills hight tests.
    /// </summary>
    public class LargestKtTests
    {
        /// <summary>
        /// Tests the largest kt tests.
        /// </summary>
        /// <param name="testingArr">The testing arr.</param>
        /// <param name="assertingStepsVal">The asserting steps val.</param>
        [Test]
        [TestCase(new int[] { 3, 2, -2, 5, -3 }, 3)]
        [TestCase(new int[] { 1, 2, 3, -4 }, 0)]
        public void TestLargestKtTests (int[] testingArr, int assertingStepsVal)
        {
            int returnd = LargestKIntegerWithMinusValDouple.LargistK(testingArr);
            Assert.AreEqual(assertingStepsVal, returnd);
        }
    }
}