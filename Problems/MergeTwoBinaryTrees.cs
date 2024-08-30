namespace LeetCode_Practice
{
    public partial class Solution {
        public TreeNode<int> MergeTrees(TreeNode<int> root1, TreeNode<int> root2) {
    
            if (root1 == null && root2 == null)
            {
                return null;
            }
    
            if (root1 == null)
            {
                return root2;
            }
    
            if (root2 == null)
            {
                return root1;
            }
    
            root1.val += root2.val;
    
            root1.left = MergeTrees(root1.left, root2.left);
            
            root1.right = MergeTrees(root1.right, root2.right);
    
            return root1;
        }
    }
    public class MergeTwoBinaryTrees
    {
        [Fact]
        public void MergeTwoBinaryTrees_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}