namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] Shuffle(int[] nums, int n) {
            int x = 0;
            int[] result = new int[nums.Length];
            for (int i = 0; i < result.Length; i++)
            {
                if (i % 2 == 0)
                {
                    result[i] = nums[x];
                    x++;
                }
                else
                {
                    result[i] = nums[n];
                    n++;
                }
            }
            return result;
        }
    }
    public class ShuffletheArray
    {
        [Fact]
        public void ShuffletheArray_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([2,3,5,4,1,7], solution.Shuffle(nums: [2,5,1,3,4,7], n: 3));
        }
    }
}