using LeetCodes1;
using NUnit.Framework;

namespace LeetCodes1Tests
{
    /// <summary>
    /// The min steps to e q pills hight tests.
    /// </summary>
    public class MaximumProductSubArrayTests
    {
        /// <summary>
        /// Tests the largest kt tests.
        /// </summary>
        /// <param name="testingArr">The testing arr.</param>
        /// <param name="assertingStepsVal">The asserting steps val.</param>
        [Test]
        [TestCase(new int[] { 6, -3, -10, 0, 2 }, 180)]
        [TestCase(new int[] { -1, -3, -10, 0, 60 }, 60)]
        [TestCase(new int[] { -2, -40, 0, -2, -3 }, 80)]
        public void TestLargestKtTests (int[] testingArr, int assertingStepsVal)
        {
            int returnd = MaximumProductSubArray.MaxSubarrayProduct(testingArr);
            Assert.AreEqual(assertingStepsVal, returnd);
        }
    }
}