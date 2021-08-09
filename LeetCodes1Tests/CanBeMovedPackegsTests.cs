using LeetCodes1;
using NUnit.Framework;
using System;
using System.Linq;

namespace LeetCodes1Tests
{
    /// <summary>
    /// The good strings tests.
    /// </summary>
    public class CanBeMovedPackegsTests
    {
        /// <summary>
        /// Tests the min to delete from string.
        /// </summary>
        /// <param name="testingString">The testing string.</param>
        /// <param name="assertingVal">The asserting val.</param>
        [Test]
        [TestCase(new int[] { 2,1}, new int[] { 5, 1 } , 3 , 6 , true)]
        [TestCase(new int[] { 2,1}, new int[] { 5, 1 } , 2 , 6 , false)]
        [TestCase(new int[] { 1,4,2}, new int[] { 10,4,7 } , 11,1 , true)]
        [TestCase(new int[] {5,5,1}, new int[] { 3,3,6 } , 4,8 , true)]
        //[TestCase(1005,1005)]
        public void TestCanBeMoved (int[] carens,int[]pos , int pB , int pE, bool assertingVal)
        {
            bool returnd = CarensAndPackages.Solution(carens , pos , pB , pE);
            Console.WriteLine(returnd);
            Assert.AreEqual(returnd, assertingVal);
        }
    }
}