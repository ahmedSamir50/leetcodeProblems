using System;

namespace LeetCodes1
{
    /// <summary>
    /// The min steps to e q pills hight.
    /// Alexa is given n piles of equal or unequal heights. In one step,
    /// Alexa can remove any number of boxes from the pile which has the maximum height and try to make it
    /// equal to the one which is just lower than the maximum height of the stack.
    /// Determine the minimum number of steps required to make all of the piles equal in height.
    /// </summary>
    public class MinStepsToEQPillsHight
    {
        /// <summary>
        /// Reqs the min steps.
        /// eg:
        /// Input: piles = [5, 2, 1]
        ///        Output: 3
        ///Explanation:
        ///Step 1: reducing 5 -> 2 [2, 2, 1]
        ///        Step 2: reducing 2 -> 1 [2, 1, 1]
        ///        Step 3: reducing 2 -> 1 [1, 1, 1]
        ///        So final number of steps required is 3.
        /// </summary>
        /// <param name="pillsArr">The pills arr.</param>
        /// <returns>An int.</returns>
        public static int ReqMinSteps (int[] pillsArr)
        {
            int stepsCount = 0;
            if (pillsArr.Length <= 1)
                return stepsCount;
            Array.Sort(pillsArr);
            Array.Reverse(pillsArr);
            for (int i = 1; i < pillsArr.Length; i++)
            {
                if (pillsArr[i] < pillsArr[i - 1])
                    stepsCount += i;
            }
            return stepsCount;
        }
    }
}