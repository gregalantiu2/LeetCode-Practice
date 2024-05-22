namespace LeetCode_Practice
{
    public partial class Solution {
        public int RemoveElement(int[] nums, int val) {
            int k = 0;

            for(int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }
            }

            return k;
        }
    }
    public class RemoveElement
    {
        [Fact]
        public void RemoveElement_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(2, solution.RemoveElement(nums: [3,2,2,3], val: 3));
        }
        [Fact]
        public void RemoveElement_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(5, solution.RemoveElement(nums: [0,1,2,2,3,0,4,2], val: 2));
        }
    }
}