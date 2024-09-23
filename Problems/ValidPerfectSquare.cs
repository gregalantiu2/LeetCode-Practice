namespace LeetCode_Practice
{
    public partial class Solution {
        public bool IsPerfectSquare(int num) {
            if (num < 2)
            {
                return true;
            }
    
            long left = 2;
    
            long right = num / 2;
    
            long guess;
    
            long guessSquared;
    
            while (left <= right)
            {
                guess = left + (right - left) / 2;
    
                guessSquared = guess * guess;
    
                if (guessSquared == num)
                {
                    return true;
                }
                else if(guessSquared > num)
                {
                    right = guess - 1;
                }
                else{
                    left = guess + 1;
                }
            }
    
            return false;
        }
    }
    1
    16
    14
    true
    false
    true
    public class ValidPerfectSquare
    {
        [Fact]
        public void ValidPerfectSquare_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(true, solution.IsPerfectSquare(num: 16));
        }
        [Fact]
        public void ValidPerfectSquare_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(false, solution.IsPerfectSquare(num: 14));
        }
    }
}