namespace LeetCode_Practice
{
    public partial class Solution {

        public int GuessNumber(int n) {
    
            for (int i = 1; i <= n; i++)
            {
                if(guess(i) == 0)
                    return i;
            }
    
            return -1;
        }
    }
    public class GuessNumberHigherorLower
    {
        [Fact]
        public void GuessNumberHigherorLower_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(X,solution.Test(x));
        }
    }
}