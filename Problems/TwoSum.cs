namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] TwoSum(int[] nums, int target) {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[2] {i, j};
                    }
                }
            }
    
            return new int[0];
        }
    }
    public class TwoSum
    {
        [Fact]
        public void TwoSum_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([0,1], solution.TwoSum(nums: [2,7,11,15], target: 9));
        }
    }
}