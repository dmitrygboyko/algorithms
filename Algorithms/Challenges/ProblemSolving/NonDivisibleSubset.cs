using System.Collections.Generic;

namespace Algorithms.Challenges.ProblemSolving
{
    public class NonDivisibleSubsetChallenge
    {
        /*
         * Given a set of distinct integers, print the size of a maximal subset of where the sum of any  numbers in  is not evenly divisible by.    
         */

        public static int NonDivisibleSubset(int k, List<int> s)
        {
            var divArray = new int[k];

            for (var i = 0; i < s.Count; i++)
            {
                var divRes = s[i] % k;

                if (divRes == 0)
                {
                    divArray[divRes] = 1;
                }
                else if (2 * divRes == k)
                {
                    divArray[divRes] = 1;
                }
                else
                {
                    divArray[divRes] = divArray[divRes] + 1;
                }
            }

            var res = 0;

            int halfK = k / 2;

            for (int i = 0; i < k; i++)
            {
                var currentValue = divArray[i];

                if (i > halfK)
                {
                    var complement = k - i;
                    var complementValue = divArray[complement];

                    if (currentValue > complementValue)
                    {
                        res -= complementValue;
                        res += currentValue;
                    }
                }
                else
                {
                    res += divArray[i];
                }
            }

            return res;
        }
    }
}
    