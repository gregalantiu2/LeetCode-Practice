namespace LeetCode_Practice
{
    public partial class Solution {
        public int HammingWeight(int n) {
            return Convert.ToString(n , 2).Count(x => x == '1');
        }
    }
    public class Numberof1Bits
    {
        [Fact]
        public void Numberof1Bits_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}