namespace LeetCode_Practice
{
    public partial class Solution {
        public int Sum(int num1, int num2) {
            return num1 + num2;
        }
    }
    public class AddTwoIntegers
    {
        [Fact]
        public void AddTwoIntegers_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(17, solution.Sum(num1: 12, num2: 5));
        }
        [Fact]
        public void AddTwoIntegers_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(-6, solution.Sum(num1: -10, num2: 4));
        }
    }
}