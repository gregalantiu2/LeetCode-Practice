namespace LeetCode_Practice
{
    public partial class Solution {
        public int LengthOfLastWord(string s) {
            var trimString = s.Trim();
    
            var stringArray = trimString.Split(" ");
    
            return stringArray[stringArray.Length - 1].Length;
        }
    }
    public class LengthofLastWord
    {
        [Fact]
        public void LengthofLastWord_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(5, solution.LengthOfLastWord(s: "Hello World"));
        }
        [Fact]
        public void LengthofLastWord_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(4, solution.LengthOfLastWord(s: "   fly me   to   the moon  "));
        }
        [Fact]
        public void LengthofLastWord_Case3()
        {
            Solution solution = new Solution();
            Assert.Equal(6, solution.LengthOfLastWord(s: "luffy is still joyboy"));
        }
    }
}