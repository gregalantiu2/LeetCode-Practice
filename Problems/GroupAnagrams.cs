namespace LeetCode_Practice
{
    public partial class Solution {
        public IList<IList<string>> GroupAnagrams(string[] strs) {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();
    
            List<IList<string>> result = new List<IList<string>>();
    
            foreach (var str in strs)
            {
                var word = str.ToCharArray();
                Array.Sort(word);
                var sortedWord = new string(word);
                
                if (dict.ContainsKey(sortedWord))
                {
                    dict[sortedWord].Add(str);
                }
                else
                {
                    dict.Add(sortedWord, new List<string>());
                    dict[sortedWord].Add(str);
                }
            }
    
            foreach (var item in dict)
            {
                result.Add(item.Value.ToList());
            }
    
            return result;
        }
    }
    public class GroupAnagrams
    {
        [Fact]
        public void GroupAnagrams_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}