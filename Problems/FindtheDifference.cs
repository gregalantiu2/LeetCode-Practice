namespace LeetCode_Practice
{
    public partial class Solution {
        public char FindTheDifference(string s, string t) {
            var char1 = s.ToCharArray();
            var char2 = t.ToCharArray();
            Array.Sort(char1);
            Array.Sort(char2);
    
            for (int i = 0; i < char1.Length; i++)
            {
                if (char1[i] != char2[i])
                {
                    return char2[i];
                }
            }
    
            return char2[char2.Length - 1];
        }
    }
    public class FindtheDifference
    {
        [Fact]
        public void FindtheDifference_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal("e", solution.FindTheDifference(s: "abcd", t: "abcde"));
        }
    }
}