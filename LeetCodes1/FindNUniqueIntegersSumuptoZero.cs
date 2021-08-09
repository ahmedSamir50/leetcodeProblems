using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodes1
{
    /// <summary>
    /// 1304. Find N Unique Integers Sum up to Zero
    /// Input: n = 5
    /// Output: [-7,-1,1,3,4]
    /// </summary>
    public class FindNUniqueIntegersSumuptoZero
    {
        /// <summary>
        /// Gets the vs.
        /// </summary>
        /// <param name="lengthOf">The length of.</param>
        /// <returns>An array of int.</returns>
        public static int[] GetVs (int lengthOf)
        {
            lengthOf = Math.Abs(lengthOf);
            if (lengthOf == 1)
                return new int[] { 0 };

            ISet<int> resArr = new HashSet<int>(lengthOf);
            bool isOdd = lengthOf % 2 != 0;
            if (isOdd)
            {
                resArr.Add(0);
                lengthOf--;
            }
            while (lengthOf > 0)
            {
                int randPosit = lengthOf + 1;
                resArr.Add(randPosit);
                resArr.Add(-randPosit);
                lengthOf -= 2;
            }

            int[] vs = resArr.ToArray();
            Array.Sort(vs);
            return vs;
        }
    }
}