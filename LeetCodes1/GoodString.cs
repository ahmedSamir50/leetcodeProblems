using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodes1
{
    /// <summary>
    /// The good string.
    /// A string s is called good if there are no two different characters in s that have the same frequency.
    //    Given a string s, return the minimum number of characters you need to delete to make s good.
    //    The frequency of a character in a string is the number of times it appears in the string. For example, in the string "aab", the frequency of 'a' is 2, while the frequency of 'b' is 1.
    //Example 1:
    //Input: s = "aab"
    //Output: 0
    //Explanation: s is already good.
    //Example 2:
    //Input: s = "aaabbbcc"
    //Output: 2
    //Explanation: You can delete two 'b's resulting in the good string "aaabcc".
    //Another way it to delete one 'b' and one 'c' resulting in the good string "aaabbc".
    //Example 3:
    //Input: s = "ceabaacb"
    //Output: 2
    //Explanation: You can delete both 'c's resulting in the good string "eabaab".
    //Note that we only care about characters that are still in the string at the end (i.e.frequency of 0 is ignored).
    /// </summary>
    public class GoodString
    {
        /// <summary>
        /// Max  to delete.
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>An int.</returns>
        public static int MaxToDelete (string s)
        {
            int resCount = 0;
            Dictionary<char, int> finds = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (finds.ContainsKey(c))
                {
                    finds[c] += 1;
                }
                else
                    finds.Add(c, 1);
            }
            if (finds.Count > 0)
            {
                List<int> piorityQueue = new List<int>();
                piorityQueue.AddRange(finds.Values);
                piorityQueue.RemoveAll(x => x == 1);
                if (piorityQueue.Count > 0)
                {
                    piorityQueue.Sort(); // 2,3,4,
                    piorityQueue.Reverse();//n,....,3,2
                    // [2,3,4,4,5,6,7,7]
                    for (int i = 1; i < piorityQueue.Count; i++)
                    {
                        int current = piorityQueue[i];
                        int prevOne = piorityQueue[i - 1];
                        // if we have the same occurrence and it's bigger than the current
                        resCount = (current > resCount && prevOne == current) ? piorityQueue[i] : resCount;
                    }
                }
            }
            return resCount;
        }

        public static int MinToDelete (string s)
        {
            int resCount = (int)Math.Pow(10, 5) + 1;
            Dictionary<char, int> finds = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (finds.ContainsKey(c))
                {
                    finds[c] += 1;
                }
                else
                    finds.Add(c, 1);
            }
            if (finds.Count > 0)
            {
                List<int> piorityQueue = new List<int>();
                piorityQueue.AddRange(finds.Values);
                piorityQueue.RemoveAll(x => x == 1);
                if (piorityQueue.Count > 0)
                {
                    piorityQueue.Sort(); // 2,2,3,4,4
                    //piorityQueue.Reverse();//n,....,3,2
                    // [2,3,4,4,5,6,7,7]
                    int theMin = piorityQueue.Min();
                    for (int i = 1; i < piorityQueue.Count; i++)
                    {
                        int current = piorityQueue[i];
                        int prevOne = piorityQueue[i - 1];
                        // if we have the same occurrence and it's bigger than the current
                        bool willAffect = (current < resCount);
                        if (willAffect && current == prevOne)
                        {
                            resCount = theMin;
                            break;
                        }
                    }
                }
            }
            return resCount == ((int)Math.Pow(10, 5) + 1) ? 0 : resCount;
        }
    }
}