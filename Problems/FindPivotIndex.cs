namespace LeetCode_Practice
{
    public partial class Solution {
        public int PivotIndex(int[] nums) {
    
            int leftTotal = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int rightTotal = 0;
    
                if (i == 0)
                {
                    for (int j = i + 1; j < nums.Length; j++)
                    {
                        rightTotal += nums[j];
                    }
    
                    if (rightTotal == 0)
                    {
                        return 0;
                    }
                }
                else{
                    leftTotal += nums[i - 1];
    
                    for (int l = i + 1; l < nums.Length; l++)
                    {
                        rightTotal += nums[l];
                    }
    
                    if (leftTotal == rightTotal)
                    {
                        return i;
                    }
                }
            }
    
            return -1;
        }
        public int PivotIndex2(int[] nums) {
            int rightTotal = nums.Sum();
            int leftTotal = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                rightTotal -= nums[i];
                if (leftTotal == rightTotal)
                {
                    return i;
                }
                leftTotal += nums[i];
            }

            return -1;
        }
    }
    public class FindPivotIndex
    {
        [Fact]
        public void FindPivotIndex_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(3, solution.PivotIndex(nums: [1,7,3,6,5,6]));
        }
        [Fact]
        public void FindPivotIndex_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(-1, solution.PivotIndex(nums: [1,2,3]));
        }
        [Fact]
        public void FindPivotIndex_Case3()
        {
            Solution solution = new Solution();
            Assert.Equal(0, solution.PivotIndex(nums: [2,1,-1]));
        }
    }
}