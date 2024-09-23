namespace LeetCode_Practice
{
    public partial class Solution {
        public bool ValidPalindrome(string s) {
            int left = 0;
            int right = s.Length - 1;
    
            while (left < right)
            {
                if (s[left] == s[right])
                {
                    left++;
                    right--;
                }
                else
                {
                    return IsValidPalindrome(s, left + 1, right) || IsValidPalindrome(s, left, right - 1);
                }
            }
    
            return true;
        }
    
        public bool IsValidPalindrome(string s, int left, int right)
        {
            while(left < right)
            {
                if (s[left] != s[right])
                {
                    return false;
                }
                left++;
                right--;
            }
    
            return true;
        }
    }
    public class ValidPalindromeII
    {
        [Fact]
        public void ValidPalindromeII_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(true, solution.ValidPalindrome(s: "abca"));
        }
    }
}