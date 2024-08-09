namespace LeetCode_Practice
{
    public partial class Solution {
        public int FinalValueAfterOperations(string[] operations) {
            int result = 0;
    
            foreach (var op in operations)
            {
                if (op == "++X" || op == "X++")
                {
                    result++;
                }
                else
                {
                    result--;
                }
            }
    
            return result;
        }
    }
    public class FinalValueofVariableAfterPerformingOperations
    {
        [Fact]
        public void FinalValueofVariableAfterPerformingOperations_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(1, solution.FinalValueAfterOperations(operations: ["--X","X++","X++"]));
        }
        [Fact]
        public void FinalValueofVariableAfterPerformingOperations_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(3, solution.FinalValueAfterOperations(operations: ["++X","++X","X++"]));
        }
        [Fact]
        public void FinalValueofVariableAfterPerformingOperations_Case3()
        {
            Solution solution = new Solution();
            Assert.Equal(0, solution.FinalValueAfterOperations(operations: ["X++","++X","--X","X--"]));
        }
    }
}