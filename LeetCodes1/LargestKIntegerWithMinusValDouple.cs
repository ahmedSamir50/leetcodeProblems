using System;
using System.Collections.Generic;

namespace LeetCodes1
{
    /// <summary>
    /// The largest k integer with minus val duplicate.
    /// Write a function that, given an array A of N integers,
    /// returns the lagest integer K > 0 such that both values K and -K exist in array A.
    /// If there is no such integer, the function should return 0.
    /// </summary>
    public class LargestKIntegerWithMinusValDouple
    {
        /// <summary>
        /// Largest the k.
        /// Input: [3, 2, -2, 5, -3]
        ///Output: 3
        ///Input: [1, 2, 3, -4]
        ///Output: 0
        /// </summary>
        /// <param name="vs">The vs.</param>
        /// <returns>An int.</returns>
        public static int LargistK (int[] vs)
        {
            int finds = 0;
            ISet<int> unequeVals = new HashSet<int>();
            for (int i = 0; i < vs.Length; i++)
            {
                // add the number reversed so when the other/opposite state number come finds his partner
                unequeVals.Add(vs[i] * -1);
                if (unequeVals.Contains(vs[i]))
                {
                    finds = Math.Max(finds, Math.Abs(vs[i]));
                }
            }
            return finds;
        }
    }
}