namespace LeetCode_Practice
{
    public partial class Solution {
        public IList<IList<int>> LevelOrder(TreeNode<int> root) {
            List<List<int>> result = new List<List<int>>();
    
            Queue<TreeNode<int>> q = new Queue<TreeNode<int>>();
    
            if (root != null)
            {
                q.Enqueue(root);
            }        
    
            while (q.Count > 0)
            {
                List<int> level = new List<int>();
                int levelLength = q.Count;
    
                for (int i = 0; i < levelLength; i++)
                {
                    var curr = q.Dequeue();
    
                    if (curr.left != null)
                        q.Enqueue(curr.left);
                    
                    if (curr.right != null)
                        q.Enqueue(curr.right);
    
                    level.Add(curr.val);
                }
                result.Add(level);
            }
    
            return new List<IList<int>>(result);
        }
    }
    public class BinaryTreeLevelOrderTraversal
    {
        [Fact]
        public void BinaryTreeLevelOrderTraversal_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}