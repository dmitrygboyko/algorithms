using System;
namespace Algorithms.Challenges.ProblemSolving
{
    public class EqualizeTheArrayChallange
    {
        public static int EqualizeArray(int[] arr)
        {
            const int counterArrayLength = 101;
            var counterArray = new int[counterArrayLength];

            for (var i = 0; i < arr.Length; i++)
            {
                counterArray[arr[i]]++;
            }

            var maxOccurance = 0;

            for (var i = 0; i < counterArrayLength; i++)
            {
                if (counterArray[i] > maxOccurance)
                {
                    maxOccurance = counterArray[i];
                }
            }

            return arr.Length - maxOccurance;
        }
    }
}
