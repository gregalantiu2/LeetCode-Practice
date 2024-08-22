namespace LeetCode_Practice
{
    public partial class Solution {
        public int MajorityElement(int[] nums) {
            Dictionary<int,int> dict = new Dictionary<int,int>();
    
            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else{
                    dict[num] += 1;
                }
            }

            return dict.OrderByDescending(x => x.Value).First().Key;
        }    
    }
    public class MajorityElement
    {
        [Fact]
        public void MajorityElement_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}