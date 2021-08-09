using LeetCodes1;
using NUnit.Framework;

namespace LeetCodes1Tests
{
    public class MinPalindromeSwapsTests
    {
        [Test]
        [TestCase("mamad", 1)]
        [TestCase("asflkj", -1)]
        [TestCase("aabb", 1)]
        [TestCase("ntiin", 1)]
        public void TestMinDirectSwapsToGitPalindorme (string testingString, int assertingVal)
        {
            int returnd = MinSwapsToGetPalindorme.MinDirectNaivigatedSwapsToGetPalindrome(testingString);
            Assert.AreEqual(assertingVal, returnd);
        }

        [Test]
        [TestCase("mamad", 3)]
        [TestCase("asflkj", -1)]
        [TestCase("aabb", 2)]
        [TestCase("ntiin", 1)]
        public void TestMinInDirectSwapsToGitPalindorme (string testingString, int assertingVal)
        {
            int returnd = MinSwapsToGetPalindorme.MinNotNaivigatedSwapsToGetPalindrome(testingString);
            Assert.AreEqual(assertingVal, returnd);
        }
    }
}