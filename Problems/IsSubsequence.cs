namespace LeetCode_Practice
{
    public partial class Solution {
        public bool IsSubsequence(string s, string t) {
            if (s.Length == 0)
            {
                return true;
            }
    
            if (t.Length == 0)
            {
                return false;
            }
    
            int t_Left = 0;
            int t_Right = t.Length - 1;
            int s_Left = 0;
            int s_Right = s.Length - 1;
            int counter = s.Length;
            
    
            while (t_Left < t_Right)
            {
                if (s[s_Left] == t[t_Left])
                {
                    s_Left++;
                    counter--;
                }
    
                if (s[s_Right] == t[t_Right])
                {
                    s_Right--;
                    counter--;
                }
    
                if (s_Right < 0 || s_Left > s.Length - 1)
                {
                    return true;
                }
    
                t_Left++;
                t_Right--;
    
                if (t_Left == t_Right)
                {
                    if (s[s_Right] == t[t_Right])
                    {
                        s_Right--;
                        counter--;
                    }
                }
            }
    
            return counter <= 0;
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