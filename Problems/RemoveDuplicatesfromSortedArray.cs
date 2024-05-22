namespace LeetCode_Practice
{
    public partial class Solution {
        public int RemoveDuplicates(int[] nums) {
            if (nums.Length == 0) {
                return 0;
            }
    
            int j = 1;
            for (int i = 1; i < nums.Length; i++) {
                if (nums[i - 1] != nums[i]) {
                    nums[j] = nums[i];
                    j++;
                }
            }
    
            return j;
        }
    }
    public class RemoveDuplicatesfromSortedArray
    {
        [Fact]
        public void RemoveDuplicatesfromSortedArray_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(2, solution.RemoveDuplicates(nums: [1,1,2]));
        }
        [Fact]
        public void RemoveDuplicatesfromSortedArray_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(5, solution.RemoveDuplicates(nums: [0,0,1,1,1,2,2,3,3,4]));
        }
    }
}