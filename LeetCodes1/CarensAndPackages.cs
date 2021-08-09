using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace LeetCodes1
{
    public class CarensAndPackages
    {
        public static bool Solution (int[] A, int[] P, int B, int E)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            // crane and crane arms coverage points &  the package moving points
            List<List<int>> cranes  = new List<List<int>>();
            List<int>  neededPoints = new List<int>();
            List<int> gaps = new List<int>();

            int posMaxLeft = Math.Min(B,E); int posMaxRight =Math.Max(B,E) ;
            neededPoints = Enumerable.Range(posMaxLeft, (posMaxRight - posMaxLeft + 1))
                                     .ToList();
            // getting arrays with the max left arm and max right arm of the careens
            for (int i = 0; i < A.Length; i++)
            {
                int left = Math.Max(0, P[i] - A[i]);
                int right = P[i] + A[i] ;
                int count = (right - left) +1;
                cranes.Add(new List<int>());
                cranes[i].AddRange(Enumerable.Range(left, count));
                cranes[i].Sort();
            }
            // finding points gaps
            for (int i = 0; i < cranes.Count; i++)
            {
                int thisCraneLeftEdge = cranes[i].Min();
                int thisCraneRightEdge = cranes[i].Max();
                bool leftIsGape = false;
                bool rightIsGape = false;
                for (int j = i+1; j < cranes.Count; j++)
                {
                    leftIsGape = !cranes[j].Contains(thisCraneLeftEdge);
                    rightIsGape = !cranes[j].Contains(thisCraneRightEdge);
                    if (leftIsGape)
                        gaps.Add(thisCraneLeftEdge);
                    
                    if (rightIsGape)
                        gaps.Add(thisCraneRightEdge);
                    
                }
            }
            cranes.ToList().ForEach(x =>
            {
                x.ForEach(y =>
                {
                    Console.Write(y + ",");
                });
            });

            if (gaps.Any(n => neededPoints.Contains(n)))
                return false;
            else
                return true;
            

        }

        /// <summary>
        /// Gets the caren arm lef and righ coverage.
        /// </summary>
        /// <param name="A">The a.</param>
        /// <param name="P">The p.</param>
        /// <param name="carinIDX">The carin i d x.</param>
        /// <param name="leftArm">The left arm.</param>
        /// <param name="rightArm">The right arm.</param>
        public static void GetCarenArmLefAndRighCoverage (int[] A, int[] P, int carinIDX, out int leftArm, out int rightArm) {
            leftArm = P[carinIDX] - A[carinIDX];
            rightArm = P[carinIDX] + A[carinIDX];
        }
    }
   
}
