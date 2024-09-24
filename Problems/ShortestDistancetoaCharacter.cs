namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] ShortestToChar(string s, char c) {
            int[] result = new int[s.Length];
            List<int> indices = new List<int>();
    
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == c)
                {
                    result[i] = 0;
                    indices.Add(i);
                }
            }
    
            for (int j = 0; j < s.Length; j++)
            {
                int? answer = null;
                for (int m = 0; m < indices.Count; m++)
                {
                    if (answer == null)
                    {
                        answer = Math.Abs(j - indices[m]);
                    }
                    else if (Math.Abs(j - indices[m]) < answer)
                    {
                        answer = Math.Abs(j - indices[m]);
                    }
                }
    
                result[j] = (int)answer;
            }
    
            return result;
        }
    }
    public class ShortestDistancetoaCharacter
    {
        [Fact]
        public void ShortestDistancetoaCharacter_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([3,2,1,0,1,0,0,1,2,2,1,0], solution.ShortestToChar(s: "loveleetcode", c: 'e'));
        }
    }
}