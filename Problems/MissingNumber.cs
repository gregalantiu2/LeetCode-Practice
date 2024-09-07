namespace LeetCode_Practice
{
    public partial class Solution {
        public int MissingNumber(int[] nums) {
            for(int i = 1; i < nums.Length; i++)
            {
                int j = i - 1;
    
                while(j >= 0 && nums[j + 1] < nums[j])
                {
                    var tmp = nums[j + 1];
                    nums[j + 1] = nums[j];
                    nums[j] = tmp;
    
                    j--;
                }
            }
    
            if (nums[0] != 0)
            {
                return 0;
            }
            
            for(int m = 0; m < nums.Length - 1; m++)
            {
                if (nums[m] + 1 != nums[m + 1])
                {
                    return nums[m] + 1;
                }
            }
    
            return nums[nums.Length - 1] + 1;
        }
    }
    public class MissingNumber
    {
        [Fact]
        public void MissingNumber_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(2, solution.MissingNumber(nums: [3,0,1]));
        }
        [Fact]
        public void MissingNumber_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(2, solution.MissingNumber(nums: [0,1]));
        }
        [Fact]
        public void MissingNumber_Case3()
        {
            Solution solution = new Solution();
            Assert.Equal(8, solution.MissingNumber(nums: [9,6,4,2,3,5,7,0,1]));
        }
    }
}