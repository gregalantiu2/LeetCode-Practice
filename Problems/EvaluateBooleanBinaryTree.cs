namespace LeetCode_Practice
{
    public partial class Solution {
        public bool EvaluateTree(TreeNode<int> node)
        {
            switch (node.val)
            {
                case 0:
                    return false;
                case 1:
                    return true;
                case 2:
                    return EvaluateTree(node.left) || EvaluateTree(node.right);
                case 3:
                    return EvaluateTree(node.left) && EvaluateTree(node.right);
                default:
                    throw new ArgumentException("Invalid node value");
            }
        }
    }
    public class EvaluateBooleanBinaryTree
    {
        [Fact]
        public void EvaluateBooleanBinaryTree_Case1()
        {
            Solution solution = new Solution();
            Assert.True(solution.EvaluateTree(new TreeNode<int> { val = 2, left = new TreeNode<int> { val = 1 }, right = new TreeNode<int> { val = 3, left = null, right = null } }));
        }
    }
}