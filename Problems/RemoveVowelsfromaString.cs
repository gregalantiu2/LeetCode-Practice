namespace LeetCode_Practice
{
    public partial class Solution {
        public string RemoveVowels(string s) {
            string result = "";
    
            foreach (var letter in s)
            {
                if (letter != 'a' && letter != 'e' && letter != 'i' && letter != 'o' && letter != 'u')
                {
                    result += letter;
                }
            }
    
            return result;
        }

        public string RemoveVowels2(string s) {
            char[] vowels = new char[5] {'a','e','i','o','u'};

            return new string(s.Where(c => !vowels.Contains(c)).ToArray());
        }
    }
    public class RemoveVowelsfromaString
    {
        [Fact]
        public void RemoveVowelsfromaString_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}