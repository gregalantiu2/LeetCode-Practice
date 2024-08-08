namespace LeetCode_Practice
{
    /**
     * Definition for a binary tree node.
     * public class TreeNode<int> {
     *     public int val;
     *     public TreeNode<int> left;
     *     public TreeNode<int> right;
     *     public TreeNode<int>(int val=0, TreeNode<int> left=null, TreeNode<int> right=null) {
     *         this.val = val;
     *         this.left = left;
     *         this.right = right;
     *     }
     * }
     */
    public partial class Solution {
        public TreeNode<int> DeleteNode(TreeNode<int> root, int key) {
            if (root == null)
                return root;
    
            if (root.val > key)
            {
                root.left = DeleteNode(root.left, key);
            }
            else if (root.val < key)
            {
                root.right = DeleteNode(root.right, key);
            }
            else
            {
                if (root.left == null && root.right == null)
                {
                    root = null;
                }
                else if (root.left == null || root.right == null)
                {
                    TreeNode<int> ret = root.left != null ? root.left : root.right;
                    root = ret;
                }
                else
                {
                    TreeNode<int> tmp = root.right;
                    while (tmp.left != null)
                    {
                        tmp = tmp.left;
                    }
                    root.val = tmp.val;
                    root.right = DeleteNode(root.right, tmp.val);
                }
            }
    
            return root;
        }
    }
    public class DeleteNodeinaBST
    {
        [Fact]
        public void DeleteNodeinaBST_Case1()
        {
            Solution solution = new Solution();
        }
        [Fact]
        public void DeleteNodeinaBST_Case2()
        {
            Solution solution = new Solution();
        }
    }
}