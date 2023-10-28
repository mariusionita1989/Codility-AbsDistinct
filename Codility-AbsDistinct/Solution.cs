using System.Runtime.CompilerServices;

namespace Codility_AbsDistinct
{
    public class Solution
    {
        public int RANGE_LOWEST_VALUE = 1;
        public int RANGE_HIGHEST_VALUE = 100000;

        [MethodImpl(MethodImplOptions.AggressiveOptimization)]
        public int solution(int[] A)
        {
            int distinctCount = 0;
            HashSet<long> distinctValues = new HashSet<long>();
            int N = A.Length;

            if (N >= RANGE_LOWEST_VALUE && N <= RANGE_HIGHEST_VALUE)
            {
                foreach (int number in A)
                {
                    long absoluteValue = Math.Abs((long)number);
                    if (distinctValues.Add(absoluteValue))
                    {
                        distinctCount++;
                    }
                }
            }

            return distinctCount;
        }
    }
}
