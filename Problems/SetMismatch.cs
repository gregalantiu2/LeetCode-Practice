namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] FindErrorNums(int[] nums) {
            int first = nums.GroupBy(x => x).Where(x=>x.Count()>1).Select(x=>x.Key).First();
            int second = Enumerable.Range(1, nums.Length).Except(nums).First();
    
            return new int[] {first, second};
        }
    }
    public class SetMismatch
    {
        [Fact]
        public void SetMismatch_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}