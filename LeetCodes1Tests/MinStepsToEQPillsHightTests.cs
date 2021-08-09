using LeetCodes1;
using NUnit.Framework;

namespace LeetCodes1Tests
{
    /// <summary>
    /// The min steps to e q pills hight tests.
    /// </summary>
    public class MinStepsToEQPillsHightTests
    {
        [Test]
        [TestCase(new int[] { 5, 2, 1 }, 3)]
        [TestCase(new int[] { 1, 1, 1 }, 0)]
        [TestCase(new int[] { 1 }, 0)]
        [TestCase(new int[] { 1, 1, 2, 2, 2, 3, 3, 3, 4, 4 }, 15)]
        public void TestMinDirectSwapsToGitPalindorme (int[] testingArr, int assertingStepsVal)
        {
            int returnd = MinStepsToEQPillsHight.ReqMinSteps(testingArr);
            Assert.AreEqual(assertingStepsVal, returnd);
        }
    }
}