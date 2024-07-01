namespace LeetCode_Practice
{
    public partial class Solution {
        public int Search(int[] nums, int target) {
            int start = 0;
            int end = nums.Length - 1;
            int mid;
    
            while(start <= end)
            {
                //find mid
                mid = (start + end) / 2;
    
                if(target < nums[mid])
                {
                    end = mid - 1;
                }
                else if(target > nums[mid])
                {
                    start = mid + 1;
                }
                else{
                    return mid;
                }
            }
    
            return -1;
        }
    }
    public class BinarySearch
    {
        [Fact]
        public void BinarySearch_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(4, solution.Search(nums: [-1,0,3,5,9,12], target: 9));
        }
        [Fact]
        public void BinarySearch_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(-1, solution.Search(nums: [-1,0,3,5,9,12], target: 2));
        }
    }
}