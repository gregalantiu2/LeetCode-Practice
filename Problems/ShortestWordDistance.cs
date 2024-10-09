namespace LeetCode_Practice
{
    public partial class Solution {
        public int ShortestDistance(string[] wordsDict, string word1, string word2) {
            List<int> word1Indexes = new List<int>();
            List<int> word2Indexes = new List<int>();
    
            for (int i = 0; i < wordsDict.Length; i++)
            {
                if (word1 == wordsDict[i])
                {
                    word1Indexes.Add(i);
                }
    
                if (word2 == wordsDict[i])
                {
                    word2Indexes.Add(i);
                }
            }
    
            var compare1 = Math.Min(Math.Abs(word1Indexes.Min() - word2Indexes.Min()), Math.Abs(word1Indexes.Max() - word2Indexes.Max()));
    
            var compare2 = Math.Min(Math.Abs(word1Indexes.Max() - word2Indexes.Min()), Math.Abs(word1Indexes.Min() - word2Indexes.Max()));
    
            return Math.Min(compare1, compare2);
        }
    }

    public class ShortestWordDistance
    {
        [Fact]
        public void ShortestWordDistance_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}