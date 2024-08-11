namespace LeetCode_Practice
{
    public partial class Solution {
        private List<int> resultList = new List<int>();
    
        public IList<int> InorderTraversal(TreeNode<int> root) {
    
            if (root == null)
            {
                return resultList;
            }
    
            InorderTraversal(root.left);
            resultList.Add(root.val);
            InorderTraversal(root.right);
    
            return resultList;
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