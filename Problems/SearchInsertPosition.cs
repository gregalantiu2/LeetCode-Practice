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