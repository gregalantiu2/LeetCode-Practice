namespace LeetCode_Practice
{
    public partial class Solution {
        public bool IsSymmetric(TreeNode<int> root) {
            return CompareSide(root.left, root.right);
        }
    
        public bool CompareSide(TreeNode<int> root1, TreeNode<int> root2)
        {
            if (root1 == null && root2 == null)
            {
                return true;
            }
    
            if (root1 == null || root2 == null)
            {
                return false;
            }
    
            if (root1.val != root2.val)
            {
                return false;
            }
    
            return CompareSide(root1.left, root2.right) && CompareSide(root1.right, root2.left);
        }
    }
    public class SymmetricTree
    {
        [Fact]
        public void SymmetricTree_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}