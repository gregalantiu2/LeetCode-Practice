namespace LeetCode_Practice
{
    public partial class Solution {
        public int SingleNumber(int[] nums) {
            Dictionary<int,int> dict = new Dictionary<int, int>();
    
            foreach (var num in nums)
            {
                if (dict.ContainsKey(num))
                {
                    dict.Remove(num);
                }
                else{
                    dict.Add(num, 0);
                }
            }
    
            return dict.Keys.First();
        }
    }
    public class SingleNumber
    {
        [Fact]
        public void SingleNumber_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}