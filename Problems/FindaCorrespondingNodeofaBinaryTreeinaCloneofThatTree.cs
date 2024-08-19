namespace LeetCode_Practice
{    
    public partial class Solution {
        public TreeNode<int> GetTargetCopy(TreeNode<int> original, TreeNode<int> cloned, TreeNode<int> target) {
            if (original is null || cloned is null)
                return null;
    
            if (original == target)
            {
                return cloned;
            }
                
            TreeNode<int> left = GetTargetCopy(original.left, cloned.left, target);
    
            if (left is not null)
            {
                return left;
            }
    
            return GetTargetCopy(original.right, cloned.right, target);
        }
    }

    public class FindaCorrespondingNodeofaBinaryTreeinaCloneofThatTree
    {
        [Fact]
        public void FindaCorrespondingNodeofaBinaryTreeinaCloneofThatTree_Case1()
        {
            Solution solution = new Solution();
            TreeNode<int> originalTree = new TreeNode<int>(7);
            originalTree.left = new TreeNode<int>(4);
            originalTree.right = new TreeNode<int>(3);
            originalTree.left.left = null;
            originalTree.left.right = null;
            originalTree.right.left = new TreeNode<int>(6);
            originalTree.right.right = new TreeNode<int>(19);
            
            TreeNode<int> clonedTree = new TreeNode<int>(7);
            clonedTree.left = new TreeNode<int>(4);
            clonedTree.right = new TreeNode<int>(3);
            clonedTree.left.left = null;
            clonedTree.left.right = null;
            clonedTree.right.left = new TreeNode<int>(6);
            clonedTree.right.right = new TreeNode<int>(19);
            
            Assert.Equal("3", solution.GetTargetCopy(originalTree, clonedTree, target: new TreeNode<int>(3)).ToString());
        }
    }
}