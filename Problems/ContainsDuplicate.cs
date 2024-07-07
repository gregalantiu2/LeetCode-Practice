namespace LeetCode_Practice
{
    public partial class Solution {
        public bool ContainsDuplicate(int[] nums) {
            Dictionary<int, int> dict = new Dictionary<int, int>();

            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    return true;
                }
                
                dict.Add(num, 1);
            }

            return false;   
        }
    }
    public class ContainsDuplicateTest
    {
        [Fact]
        public void ContainsDuplicate_Case1()
        {
            // Solution solution = new Solution();
            // Assert.Equal(X,solution.Test(x));
        }
    }
}