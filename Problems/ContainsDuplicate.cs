namespace LeetCode_Practice
{
    public partial class Solution {
        public bool ContainsDuplicate(int[] nums) {
            bool containsDupe = false;
    
            for (int i = 0; i < nums.Length; i++)
            {
                for (int n = i + 1; n < nums.Length; n++)
                {
                    if (nums[i] == nums[n])
                        containsDupe = true;
                }
            }
            return containsDupe;
        }
    }
    public class ContainsDuplicate
    {
        [Fact]
        public void ContainsDuplicate_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(X,solution.Test(x));
        }
    }
}