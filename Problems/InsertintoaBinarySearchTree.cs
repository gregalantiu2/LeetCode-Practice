namespace LeetCode_Practice
{
    public partial class Solution {
        public TreeNode<int> InsertIntoBST(TreeNode<int> root, int val) {
            if (root == null)
            {
                return new TreeNode<int>(val);
            }
    
            if (val > root.val)
            {
                root.right = InsertIntoBST(root.right, val);
            }
    
            if (val < root.val)
            {
                root.left = InsertIntoBST(root.left, val);
            }
            
            return root;
        }
    }
    public class InsertintoaBinarySearchTree
    {
        [Fact]
        public void InsertintoaBinarySearchTree_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal([4,2,7,1,3,5], solution.(root: [4,2,7,1,3], val: 5));
        }
    }
}