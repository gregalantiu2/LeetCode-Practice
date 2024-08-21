namespace LeetCode_Practice
{
    public partial class Solution {
        public TreeNode IncreasingBST(TreeNode root) {
            if (root is null)
            {
                return null;
            }
    
            IncreasingBST(root.left);
            
            IncreasingBST(root.right);
    
            return root;
        }
    }
    public class IncreasingOrderSearchTree
    {
        [Fact]
        public void IncreasingOrderSearchTree_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(X,solution.Test(x));
        }
    }
}