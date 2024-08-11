namespace LeetCode_Practice
{
    public partial class Solution {
        private List<int> result = new List<int>();
    
        public IList<int> InorderTraversal(TreeNode<int> root) {
    
            if (root == null)
            {
                return result;
            }
    
            InorderTraversal(root.left);
            result.Add(root.val);
            InorderTraversal(root.right);
    
            return result;
        }
    }
    public class BinaryTreeInorderTraversal
    {
        [Fact]
        public void BinaryTreeInorderTraversal_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}