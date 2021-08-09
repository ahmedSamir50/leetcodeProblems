using System;
using System.Linq;

namespace LeetCodes1
{
    /// <summary>
    /// The m in swaps to get palindrome.
    /// </summary>
    public class MinSwapsToGetPalindorme
    {
        //the minimum number of adjacent swaps required to convert a string into a palindrome
        // this is defining th right palindrome position directly
        public static int MinDirectNaivigatedSwapsToGetPalindrome (string str)
        {
            if (str.Length == 1 || !CanBePalindorme(str))
                return -1;

            int swaps = 0;
            int leftPos = 0; int rightPos = str.Length; int midPos = (str.Length / 2) + 1;
            char[] strAsArray = str.ToCharArray();
            while (leftPos < rightPos)
            {
                if (strAsArray[leftPos] != strAsArray[rightPos - 1])
                {
                    int firstMatching = FirstMatchPosition(strAsArray, strAsArray[leftPos], leftPos);
                    if (firstMatching != -1)
                    {
                        int corrispPalindromPos = CorrispondingPalindromePosition(leftPos, strAsArray.Length) - 1;
                        Swap(strAsArray, firstMatching, corrispPalindromPos);
                        swaps++;
                    }
                    else { Swap(strAsArray, leftPos, midPos); swaps++; }
                }
                leftPos++; rightPos--;
            }
            return swaps;
            //abba
        }

        // this is the required solution swing to the right pos step by step ** slower
        public static int MinNotNaivigatedSwapsToGetPalindrome (string str)
        {
            if (str.Length == 1 || !CanBePalindorme(str))
                return -1;

            int swaps = 0;
            int leftPos = 0; int rightPos = str.Length; int midPos = (str.Length / 2);
            char[] strAsArray = str.ToCharArray();

            while (leftPos < rightPos)
            {
                if (strAsArray[leftPos] != strAsArray[rightPos - 1])
                {
                    int firstMatching = FirstMatchPosition(strAsArray, strAsArray[leftPos], leftPos);
                    if (firstMatching != -1)
                    {
                        int corrispPalindromPos = CorrispondingPalindromePosition(leftPos, strAsArray.Length) - 1;
                        bool notArrived = true;
                        int nextPos = firstMatching + 1;
                        while (notArrived)
                        {
                            Swap(strAsArray, firstMatching, nextPos);
                            swaps++; nextPos++; firstMatching++;
                            if (nextPos > corrispPalindromPos || nextPos >= strAsArray.Length) notArrived = false;
                        }
                    }
                    else
                    {
                        Swap(strAsArray, leftPos, midPos);
                        swaps++;
                    }
                }
                leftPos++; rightPos--;
            }
            return swaps;
            //abba
        }

        private static int CorrispondingPalindromePosition (int leftCharPos, int arrayLength)
        {
            // 0,1,2,3,4,5,6,7,8
            return Math.Abs(arrayLength - leftCharPos);
        }

        private static int FirstMatchPosition<T> (T[] typeArray, T toFindElem, int afterPos = -2)
        {
            for (int i = Math.Max(0, afterPos + 1); i < typeArray.Length; i++)
            {
                if (typeArray[i].Equals(toFindElem)) return i;
            }
            return -1;
        }

        /// <summary>
        /// Swaps Two Elements in Array of Type T
        /// </summary>
        /// <param name="typeArray">The type array.</param>
        /// <param name="leftIDX">The left index.</param>
        /// <param name="rightIDX">The right index.</param>
        private static void Swap<T> (T[] typeArray, int leftIDX, int rightIDX)
        {
            T temp = typeArray[leftIDX];
            typeArray[leftIDX] = typeArray[rightIDX];
            typeArray[rightIDX] = temp;
        }

        /// <summary>
        /// CanBePalindorme ,  palindorme.abcxcba => is palindrome
        /// xccbbaa is shuffeled palindorm and this is to chif if it could be palindorme
        /// </summary>
        /// <param name="s">The s.</param>
        /// <returns>A bool.</returns>
        private static bool CanBePalindorme (string s)
        {
            s = s.ToLower();
            // array for 26 from a to z chars
            int[] charsOccuranceArray = new int[26];
            foreach (char c in s) charsOccuranceArray[c - 'a']++;
            return charsOccuranceArray.ToList().Where(x => x % 2 != 0).Count() <= 1;
        }
    }
}