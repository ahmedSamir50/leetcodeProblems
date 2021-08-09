using LeetCodes1;
using NUnit.Framework;

namespace LeetCodes1Tests
{
    /// <summary>
    /// The min steps to e q pills hight tests.
    /// </summary>
    public class MaxLenOfStringWithUniqCharsTests
    {
        [Test]
        [TestCase(new string[] { "un", "iq", "ue" }, 4)]
        [TestCase(new string[] { "cha", "r", "act", "ers" }, 6)]
        [TestCase(new string[] { "abcdefghijklmnopqrstuvwxyz" }, 26)]
        //wrong test case [TestCase(new string[]{"a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p"}, 16)]
        public void TestMaxConductedUnequeLength (string[] testingArr, int assertingStepsVal)
        {
            int returnd = MaxLenOfStringWithUniqChars.MaxLength(testingArr);
            Assert.AreEqual(assertingStepsVal, returnd);
        }
    }
}