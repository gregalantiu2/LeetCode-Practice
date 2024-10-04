namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] GetSneakyNumbers(int[] nums) {
            HashSet<int> set = new HashSet<int>();
            List<int> result = new List<int>();
    
            foreach (var num in nums)
            {
                if (set.Contains(num))
                {
                    result.Add(num);
                }
                else{
                    set.Add(num);
                }
            }
    
            return result.ToArray();
        }
        public int[] GetSneakyNumbers2(int[] nums) {
            return nums.GroupBy(c => c).Where(x => x.Count() > 1).Select(x => x.Key).ToArray();
        }
    }
    public class TheTwoSneakyNumbersofDigitville
    {
        [Fact]
        public void TheTwoSneakyNumbersofDigitville_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}