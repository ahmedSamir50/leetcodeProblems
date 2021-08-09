using System;

namespace LeetCodes1
{
    /// <summary>
    /// The maximum product sub array.
    /// Given an array that contains both positive and negative integers,
    /// find the product of the maximum product subarray.
    /// Expected Time complexity is O(n) and only O(1) extra space can be used.
    /// Input: arr[] = {6, -3, -10, 0, 2}
    ///Output:   180  // The subarray is {6, -3, -10}
    ///Input: arr[] = {-1, -3, -10, 0, 60}
    ///Output: 60  // The subarray is {60}
    ///Input: arr[] = { -2, -40, 0, -2, -3 }
    ///Output: 80  // The subarray is {-2, -40}
    /// </summary>
    public class MaximumProductSubArray
    {
        /// <summary>
        /// Maxes the sub array product.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <returns>An int.</returns>
        public static int MaxSubarrayProduct (int[] arr)
        {
            // could be tow contagious pairs or only one if it's contagious element is 0 and it's the max alone
            int maxProductResult = Math.Abs(arr[0]);
            for (int i = 0; i < arr.Length; i++)
            {
                int innerProd = Math.Abs(arr[i]);
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (innerProd * Math.Abs(arr[j]) == 0)
                    {
                        maxProductResult = Math.Max(innerProd, Math.Max(maxProductResult, Math.Abs(arr[j])));
                        continue;
                    }
                    innerProd *= Math.Abs(arr[j]);
                }
            }
            return maxProductResult;
        }
    }
}