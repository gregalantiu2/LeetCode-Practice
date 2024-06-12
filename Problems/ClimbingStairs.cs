namespace LeetCode_Practice
{
    public partial class Solution {
        public int ClimbStairs(int n) {
            int prev = 1;
            int curr = 1;
            for(int i = 1; i < n; i++){
                int temp = curr;
                curr += prev;
                prev = temp;
            }
            return curr;
        }
    
            
    }
    public class ClimbingStairs
    {
        [Fact]
        public void ClimbingStairs_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(2, solution.ClimbStairs(n: 2));
        }
        [Fact]
        public void ClimbingStairs_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(3, solution.ClimbStairs(n: 3));
        }
        [Fact]
        public void ClimbingStairs_Case3()
        {
            Solution solution = new Solution();
            Assert.Equal(8, solution.ClimbStairs(n: 5));
        }
    }
}