namespace LeetCode_Practice
{
    public partial class Solution {
        public bool IsAnagram(string s, string t) {
            if (s.Length != t.Length)
            {
                return false;
            }
    
            Dictionary<char,int> word1 = new Dictionary<char,int>();
            Dictionary<char,int> word2 = new Dictionary<char,int>();
    
            foreach (var letter in s)
            {
                if (!word1.ContainsKey(letter))
                {
                    word1.Add(letter, 1);
                }
    
                word1[letter]++;
            }
    
            foreach (var letter in t)
            {
                if (!word2.ContainsKey(letter))
                {
                    word2.Add(letter, 1);
                }
    
                word2[letter]++;
            }
    
            return word1.Count == word2.Count && !word1.Except(word2).Any() && !word2.Except(word1).Any(); 
        }
    }
    public class ValidAnagram
    {
        [Fact]
        public void ValidAnagram_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}