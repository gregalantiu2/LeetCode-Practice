using System.ComponentModel.Design.Serialization;

namespace LeetCode_Practice
{
    public partial class Solution {    
        public TreeNode<int?> BuildTree(int[] preorder, int[] inorder) {
            if (preorder is null || !preorder.Any() || inorder is null || !inorder.Any())
            {
                return null;
            }

            var root = new TreeNode<int?>(preorder[0]);
    
            int mid = Array.IndexOf(inorder, root.val);
    
            root.left = BuildTree(preorder[1..(mid + 1)], inorder[..mid]);
            root.right = BuildTree(preorder[(mid + 1)..], inorder[(mid + 1)..]);
    
            return root;
        }
    }
    public class ConstructBinaryTreefromPreorderandInorderTraversal
    {
        [Fact]
        public void ConstructBinaryTreefromPreorderandInorderTraversal_Case1()
        {
            Solution solution = new Solution();
            TreeNode<int?> expectedTree = new TreeNode<int?>(3);
            expectedTree.left = new TreeNode<int?>(9);
            expectedTree.right = new TreeNode<int?>(20);
            expectedTree.right.left = new TreeNode<int?>(15);
            expectedTree.right.right = new TreeNode<int?>(7);
            
            Assert.True(AreTreesEqual(expectedTree, solution.BuildTree(preorder: new int[] { 3, 9, 20, 15, 7 }, inorder: new int[] { 9, 3, 15, 20, 7 })));
            
            // Helper method to compare two trees
            bool AreTreesEqual(TreeNode<int?> tree1, TreeNode<int?> tree2)
            {
                if (tree1 == null && tree2 == null)
                    return true;
                if (tree1 == null || tree2 == null)
                    return false;
                return tree1.val == tree2.val && AreTreesEqual(tree1.left, tree2.left) && AreTreesEqual(tree1.right, tree2.right);
            }
        }
    }
}