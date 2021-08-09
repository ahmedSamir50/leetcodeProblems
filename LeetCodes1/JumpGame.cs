using System.Collections.Generic;

namespace LeetCodes1
{
    /// <summary>
    /// The jump game.
    /// You are given an array of non-negative integers arr and a start index. When you are at an index i,
    /// you can move left or right by arr[i]. Your task is to figure out if you can reach value 0.
    /// Given an array of non-negative integers arr,
    /// you are initially positioned at start index of the array.
    /// When you are at index i, you can jump to i + arr[i] or i - arr[i],
    /// check if you can reach to any index with value 0.
    /// Notice that you can not jump outside of the array at any time.
    ///    Input: arr = [4,2,3,0,3,1,2], start = 5
    ///Output: true
    ///Explanation:
    ///All possible ways to reach at index 3 with value 0 are:
    ///index 5 -> index 4 -> index 1 -> index 3
    ///index 5 -> index 6 -> index 4 -> index 1 -> index 3
    /// </summary>
    public class JumpGame
    {
        /// <summary>
        /// Zers the can be reached.
        /// </summary>
        /// <param name="jumbingArr">The jumbing arr.</param>
        /// <param name="starttingPOS">The startting p o s.</param>
        /// <returns>A bool.</returns>
        public static bool ZeroCanBeReached (int[] jumbingArr, int starttingPOS, HashSet<int> visitedPos = null)
        {
            if (visitedPos == null) visitedPos = new HashSet<int>();
            int zeroPlace = FindZeroPosINDX(jumbingArr);
            int cPos = starttingPOS;
            int sutableRight = cPos + jumbingArr[cPos];
            bool rightIsVisited = visitedPos.Contains(sutableRight);
            int sutableLeft = cPos - jumbingArr[cPos];
            bool leftIsVisited = visitedPos.Contains(sutableLeft);
            if (zeroPlace == -1)
                return false;
            else
            {
                if (leftIsVisited && rightIsVisited)
                    return false;

                if (sutableRight < jumbingArr.Length && !rightIsVisited)
                {
                    if (jumbingArr[sutableRight] == 0)
                        return true;
                    visitedPos.Add(sutableRight);
                    cPos = sutableRight;
                    return ZeroCanBeReached(jumbingArr, cPos, visitedPos);
                }
                //
                else if (sutableLeft >= 0 && sutableLeft < jumbingArr.Length && !visitedPos.Contains(sutableLeft))
                {
                    if (jumbingArr[sutableLeft] == 0)
                        return true;
                    visitedPos.Add(sutableLeft);
                    cPos = sutableLeft;
                    return ZeroCanBeReached(jumbingArr, cPos, visitedPos);
                    //continue;
                }
                else return false;
            }
        }

        /// <summary>
        /// Finds the zero pos i n d x.
        /// </summary>
        /// <param name="jumbingArr">The jumbing arr.</param>
        /// <returns>An int.</returns>
        public static int FindZeroPosINDX (int[] jumbingArr)
        {
            for (int i = 0; i < jumbingArr.Length; i++)
                if (jumbingArr[i] == 0)
                    return i;
            return -1;
        }
    }
}