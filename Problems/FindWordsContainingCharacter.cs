namespace LeetCode_Practice
{
    public partial class Solution {
        public IList<int> FindWordsContaining(string[] words, char x) {
            List<int> indices = new List<int>();
            
            for (int i = 0; i < words.Length; i++) {
                if (words[i].Contains(x)) {
                    indices.Add(i);
                }
            }
            
            return indices;
        }
    }
    public class FindWordsContainingCharacter
    {
        [Fact]
        public void FindWordsContainingCharacter_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([0,1], solution.FindWordsContaining(words: ["leet","code"], x: 'e'));
        }
        [Fact]
        public void FindWordsContainingCharacter_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal([0,2], solution.FindWordsContaining(words: ["abc","bcd","aaaa","cbc"], x: 'a'));
        }
        [Fact]
        public void FindWordsContainingCharacter_Case3()
        {
            Solution solution = new Solution();
            Assert.Equal([], solution.FindWordsContaining(words: ["abc","bcd","aaaa","cbc"], x: 'z'));
        }
    }
}