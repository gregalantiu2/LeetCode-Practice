namespace LeetCode_Practice
{
    public partial class Solution {
        public TreeNode<int> SearchBST(TreeNode<int> root, int val) {
            if (root == null)
                return null;
            
            if (root.val < val)
            {
                return SearchBST(root.right, val);
            }
    
            if (root.val > val)
            {
                return SearchBST(root.left, val);
            }
    
            return root;
        }
    }
    public class SearchinaBinarySearchTree
    {
        [Fact]
        public void SearchinaBinarySearchTree_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}