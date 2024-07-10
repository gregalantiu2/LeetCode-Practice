namespace LeetCode_Practice
{
    public partial class Solution {
        public int StrStr(string haystack, string needle) {
            return haystack.IndexOf(needle);
        }
    }
    public class FindtheIndexoftheFirstOccurrenceinaString
    {
        [Fact]
        public void FindtheIndexoftheFirstOccurrenceinaString_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(0, solution.StrStr(haystack: "sadbutsad", needle: "sad"));
        }
        [Fact]
        public void FindtheIndexoftheFirstOccurrenceinaString_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(-1, solution.StrStr(haystack: "leetcode", needle: "leeto"));
        }
    }
}