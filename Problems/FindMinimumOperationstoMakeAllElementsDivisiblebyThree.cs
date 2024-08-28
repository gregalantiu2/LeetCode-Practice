namespace LeetCode_Practice
{
    public partial class Solution {
        public int MinimumOperations(int[] nums) {
            int result = 0;
    
            foreach (var num in nums)
            {
                if (num % 3 != 0)
                {
                    result++;
                }
            }
    
            return result;
        }
    }
    public class FindMinimumOperationstoMakeAllElementsDivisiblebyThree
    {
        [Fact]
        public void FindMinimumOperationstoMakeAllElementsDivisiblebyThree_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}