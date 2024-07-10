namespace LeetCode_Practice
{
    public partial class Solution {
        public int SearchInsert(int[] nums, int target) {
            int i = 0;
            foreach (var num in nums)
            {
                if (num < target)
                {
                    i++;
                    continue;
                }
                else if(num == target)
                {
                    return i;
                }
                else{
                    break;
                }
            }
    
            return i;
        }

        public int SearchInsertBinarySearch(int[] nums, int target) {
            int left = 0;
            int right = nums.Length - 1;
            var mid = left + (right - left) / 2;

            while (left <= right)
            {
                mid = left + (right - left) / 2;

                if (target < nums[mid])
                {   
                    right = mid - 1;
                }
                else if (target > nums[mid])
                {
                    left = mid + 1;
                }
                else{
                    break;
                }
        }

        if (target > nums[mid])
            return mid + 1;
        else
            return mid;
    }
    }
    public class SearchInsertPosition
    {
        [Fact]
        public void SearchInsertPosition_Case1()
        {
            Solution solution = new Solution();
            // Assert.Equal(X,solution.Test(x));
        }
    }
}