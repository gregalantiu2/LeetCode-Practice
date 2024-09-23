namespace LeetCode_Practice
{
    public partial class Solution {
        List<int> result = new List<int>();
        public IList<int> PreorderTraversal(TreeNode root) {
    
            if (root == null)
            {
                return result;
            }
    
            result.Add(root.val);
            PreorderTraversal(root.left);
            PreorderTraversal(root.right);
    
            return result;
        }
    }
    [
    [1,null,2,3]
    [1,2,3,4,5,null,8,null,null,6,7,9]
    []
    [1]
    [1,2,3]
    [1,2,4,5,6,7,3,8,9]
    []
    [1]
    [1,2,3]
    [1,2,4,5,6,7,3,8,9]
    []
    public class BinaryTreePreorderTraversal
    {
        [Fact]
        public void BinaryTreePreorderTraversal_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(X,solution.Test(x));
        }
    }
}