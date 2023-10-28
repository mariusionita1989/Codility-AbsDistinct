using Codility_AbsDistinct;

namespace Codility_AbsDistinctTests
{
    public class SolutionTests
    {
        [Fact]
        public void TestDistinctCountWithSortedArray()
        {
            int[] A = { -5, -3, -1, 0, 3, 6 };
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestDistinctCountWithSingleElement()
        {
            int[] A = { 42 };
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(1, result);
        }

        [Fact]
        public void TestDistinctCountWithEmptyArray()
        {
            int[] A = { };
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(0, result);
        }

        [Fact]
        public void TestDistinctCountWithNegativeValues()
        {
            int[] A = { -5, -5, -3, -3, -1, -1, 0, 3, 6 };
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(5, result);
        }

        [Fact]
        public void TestDistinctCountWithLargeArray()
        {
            Solution temp = new Solution();
            int[] A = new int[temp.RANGE_HIGHEST_VALUE];
            for (int i = 0; i < temp.RANGE_HIGHEST_VALUE; i++)
            {
                A[i] = i;
            }
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(temp.RANGE_HIGHEST_VALUE, result);
        }

        [Fact]
        public void TestDistinctCountWithDuplicates()
        {
            int[] A = { -5, -5, -3, -3, -1, -1, 0, 0, 3, 6 };
            Solution solution = new Solution();
            int result = solution.solution(A);
            Assert.Equal(5, result);
        }
    }
}