namespace LeetCode_Practice
{
    public partial class Solution {
        public int Fib(int n) {
            if (n == 0)
                return 0;
            
            if (n == 1)
                return 1;
        
            return Fib(n - 1) + Fib(n - 2); 
        }
    }
    public class FibonacciNumber
    {
        [Fact]
        public void FibonacciNumber_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(1, solution.Fib(n: 2));
        }
        [Fact]
        public void FibonacciNumber_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(2, solution.Fib(n: 3));
        }
        [Fact]
        public void FibonacciNumber_Case3()
        {
            Solution solution = new Solution();
            Assert.Equal(3, solution.Fib(n: 4));
        }
    }
}