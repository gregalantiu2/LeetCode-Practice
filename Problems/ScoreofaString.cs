namespace LeetCode_Practice
{
    public partial class Solution {
        public int ScoreOfString(string s) {
            int score = 0;
        
            for (int i = 0; i < s.Length - 1; i++)
            {
                score += Math.Abs(s[i] - s[i + 1]);
            }
    
            return score;
        }
    }
    public class ScoreofaString
    {
        [Fact]
        public void ScoreofaString_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}