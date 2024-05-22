namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] GetConcatenation(int[] nums) {
            int n = nums.Length;

            int[] ans = new int[n * 2];

            for (int i = 0; i < nums.Length; i++)
            {
                ans[i] = nums[i];
                ans[i + n] = nums[i];
            }

            return ans;
        }
    }
    public class ConcatenationofArray
    {
        [Fact]
        public void ConcatenationofArray_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([1,2,1,1,2,1], solution.GetConcatenation(nums: [1,2,1]));
        }
        [Fact]
        public void ConcatenationofArray_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal([1,3,2,1,1,3,2,1], solution.GetConcatenation(nums: [1,3,2,1]));
        }
    }
}