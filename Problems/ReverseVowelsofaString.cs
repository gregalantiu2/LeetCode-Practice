namespace LeetCode_Practice
{
    public partial class Solution {
        public string ReverseVowels(string s) {
            List<char> vowels = new List<char> {'A', 'a', 'E', 'e', 'I', 'i', 'O','o', 'U', 'u'};
    
            int l = 0;
            int r = s.Length - 1;
    
            StringBuilder sb = new StringBuilder(s);
    
            while (l < r)
            {
                if(vowels.Contains(sb[l]) && vowels.Contains(sb[r]))
                {
                    var tmp = sb[r];
                    sb[r] = sb[l];
                    sb[l] = tmp;
    
                    l++;
                    r--;
                }
                
                if (!vowels.Contains(sb[l]))
                {
                    l++;
                }
    
                if (!vowels.Contains(sb[r]))
                {
                    r--;
                }
            }
    
            return sb.ToString();
        }
    }
    public class ReverseVowelsofaString
    {
        [Fact]
        public void ReverseVowelsofaString_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}