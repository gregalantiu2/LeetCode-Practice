namespace LeetCode_Practice
{
    public partial class Solution {
        public bool HasPathSum(TreeNode<int> root, int targetSum) {
            return HasPathSum(root, targetSum, 0);
        }
        
        private bool HasPathSum(TreeNode<int> root, int targetSum, int currentSum) {
            if (root is null) {
                return false;
            }
        
            currentSum += root.val;
        
            if (root.left == null && root.right == null) {
                return currentSum == targetSum;
            }
        
            return HasPathSum(root.left, targetSum, currentSum) || HasPathSum(root.right, targetSum, currentSum);
        }
    }
    public class PathSum
    {
        [Fact]
        public void PathSum_Case1()
        {
            Solution solution = new Solution();
            TreeNode<int> root = new TreeNode<int>(5);
            root.left = new TreeNode<int>(4);
            root.left.left = new TreeNode<int>(11);
            root.left.left.left = new TreeNode<int>(7);
            root.left.left.right = new TreeNode<int>(2);
            root.right = new TreeNode<int>(8);
            root.right.left = new TreeNode<int>(13);
            root.right.right = new TreeNode<int>(4);
            root.right.right.right = new TreeNode<int>(1);
            
            Assert.True(solution.HasPathSum(root, 22));
        }
        [Fact]
        public void PathSum_Case2()
        {
            Solution solution = new Solution();
            TreeNode<int> root = new TreeNode<int>(1)
            {
                left = new TreeNode<int>(2),
                right = new TreeNode<int>(3)
            };
            Assert.False(solution.HasPathSum(root, 5));
        }
        [Fact]
        public void PathSum_Case3()
        {
            Solution solution = new Solution();
            Assert.False(solution.HasPathSum(root: null, targetSum: 0));
        }
    }
}