using System;
using System.Collections.Generic;
using System.Linq;

namespace LeetCodes1
{
    /// <summary>
    /// The max len of string with uniq chars.
    /// Given an array of strings arr.
    /// String s is a concatenation of a sub-sequence of arr which have unique characters.
    ///Return the maximum possible length of s.
    /// </summary>
    public class MaxLenOfStringWithUniqChars
    {
        /// <summary>
        /// Maxes the length.
        /// Input: arr = ["un","iq","ue"]
        ///        Output: 4
        ///Explanation: All possible concatenations are "","un","iq","ue","uniq" and "ique".
        ///Maximum length is 4.
        ///            Input: arr = ["cha","r","act","ers"]
        ///        Output: 6
        ///Explanation: Possible solutions are "chaers" and "acters".
        ///            Input: arr = ["abcdefghijklmnopqrstuvwxyz"]
        ///        Output: 26
        /// </summary>
        /// <param name="arrStr">The arr str.</param>
        /// <returns>An int.</returns>
        public static int MaxLength (string[] arrStr)
        {
            if (arrStr.Length < 1)
                return 0;
            else if (arrStr.Length == 1)
                return arrStr[0].Length;
            else
            {
                ISet<char> currentUnequeChars = new HashSet<char>();
                for (int i = 0; i < arrStr.Length; i++)
                {
                    for (int j = i; j < arrStr.Length; j++)
                    {
                        string longst = arrStr[i] + arrStr[j];
                        ISet<char> tempUnequeChars = longst.ToHashSet();
                        if (tempUnequeChars.Count > currentUnequeChars.Count)
                        {
                            currentUnequeChars = tempUnequeChars;
                            //PrintCollection(currentUnequeChars);
                        }
                    }
                }

                return currentUnequeChars.Count;
            }
        }

        public static int MaxLength (IList<string>[] arr)
        {
            return MaxLength(arr.ToArray());
        }

        public static void PrintCollection<T> (ICollection<T> arrCollection)
        {
            for (int i = 0; i < arrCollection.Count; i++)
                Console.Write(arrCollection.ElementAt(i));
            Console.WriteLine("------");
        }
    }
}