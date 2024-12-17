namespace LeetCode_Practice
{
    public partial class Solution {
        public bool IsBalanced(TreeNode<int> root) {
            if (root is null)
            {
                return true;
            }
    
            if (Math.Abs(GetHeight(root.left) - GetHeight(root.right)) > 1)
            {
                return false;
            }
    
            return IsBalanced(root.left) && IsBalanced(root.right);
        }
    
        public int GetHeight(TreeNode<int> root)
        {
            if (root is null)
            {
                return 0;
            }
    
            return Math.Max(GetHeight(root.left), GetHeight(root.right)) + 1;
        }
    }
    public class BalancedBinaryTree
    {
        [Fact]
        public void BalancedBinaryTree_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}