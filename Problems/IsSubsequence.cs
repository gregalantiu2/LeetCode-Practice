namespace LeetCode_Practice
{
    public partial class Solution {
        public bool IsSubsequence(string s, string t) {
            int i = 0;
            int j = 0;

            if (s.Length < 1)
            {
                return true;
            }

            if (t.Length < 1)
            {
                return false;
            }

            while (j < t.Length)
            {
                if (s[i] == t[j])
                {
                    i++;
                    if (i == s.Length)
                    {
                        return true;
                    }
                }
                j++;
            }

            return false;
        }
    }
    public class IsSubsequence
    {
        [Fact]
        public void IsSubsequence_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}