namespace LeetCode_Practice
{
    public partial class Solution {
        public bool IsPalindrome(string s) {
            var trimmed = new String(s.Where(Char.IsLetterOrDigit).ToArray()).ToLower();
            int l = 0;
            int r = trimmed.Length - 1;
            
            while(l < r)
            {
                if (trimmed[l] == trimmed[r])
                {
                    l++;
                    r--;
                }
                else{
                    return false;
                }
            }
    
            return true;
        }
    }
    public class ValidPalindrome
    {
        [Fact]
        public void ValidPalindrome_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(true, solution.IsPalindrome(s: "A man, a plan, a canal: Panama"));
        }
        [Fact]
        public void ValidPalindrome_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(false, solution.IsPalindrome(s: "race a car"));
        }
        [Fact]
        public void ValidPalindrome_Case3()
        {
            Solution solution = new Solution();
            Assert.Equal(true, solution.IsPalindrome(s: " "));
        }
    }
}