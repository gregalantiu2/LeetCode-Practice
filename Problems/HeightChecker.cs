namespace LeetCode_Practice
{
    public partial class Solution {
        public int HeightChecker(int[] heights) {
            int[] expected = heights.OrderBy(x => x).ToArray();
    
            int result = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != expected[i])
                {
                    result++;
                }
            }
    
            return result;
        }
    }
    [
    [1,1,4,2,1,3]
    [5,1,2,3,4]
    [1,2,3,4,5]
    3
    5
    0
    3
    5
    public class HeightChecker
    {
        [Fact]
        public void HeightChecker_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(3, solution.HeightChecker(heights: [1,1,4,2,1,3]));
        }
        [Fact]
        public void HeightChecker_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(5, solution.HeightChecker(heights: [5,1,2,3,4]));
        }
        [Fact]
        public void HeightChecker_Case3()
        {
            Solution solution = new Solution();
            Assert.Equal(0, solution.HeightChecker(heights: [1,2,3,4,5]));
        }
    }
}