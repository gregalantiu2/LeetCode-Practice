namespace LeetCode_Practice
{
    public partial class Solution {
        public int NumJewelsInStones(string jewels, string stones) {
            HashSet<char> hs = new HashSet<char>();
    
            foreach(var jewel in jewels)
            {
                hs.Add(jewel);
            }
    
            int result = 0;
    
            foreach (var stone in stones)
            {
                if (hs.Contains(stone))
                {
                    result++;
                }
            }
    
            return result;
        }
    }
    public class JewelsandStones
    {
        [Fact]
        public void JewelsandStones_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}