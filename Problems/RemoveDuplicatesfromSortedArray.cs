namespace LeetCode_Practice
{
    public partial class Solution {
        public int RemoveDuplicates(int[] nums) {
            if (nums.Length == 0) {
                return 0;
            }
    
            int j = 0;
            for (int i = 1; i < nums.Length; i++) {
                if (nums[j] != nums[i]) {
                    nums[++j] = nums[i];
                }
            }
    
            return j + 1;
        }
    }
    public class RemoveDuplicatesfromSortedArray
    {
        [Fact]
        public void RemoveDuplicatesfromSortedArray_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(2, nums: [1,2,_], solution.RemoveDuplicates(nums: [1,1,2]));
        }
        [Fact]
        public void RemoveDuplicatesfromSortedArray_Case2()
        {
            Solution solution = new Solution();
            //Assert.Equal(5, nums: [0,1,2,3,4,_,_,_,_,_], solution.RemoveDuplicates(nums: [0,0,1,1,1,2,2,3,3,4]));
        }
    }
}