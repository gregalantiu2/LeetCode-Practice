namespace LeetCode_Practice
{
    public partial class Solution {
        public int MaxDepth(TreeNode<int> root) {
            int levels = 0;
    
            if (root == null)
            {
                return levels;
            }
    
            Queue<TreeNode<int>> nodes = new Queue<TreeNode<int>>();
    
            nodes.Enqueue(root);
    
            while (nodes.Any())
            {
                int levelLength = nodes.Count;
    
                for (int i = 0; i < levelLength; i++)
                {
                    var curr = nodes.Dequeue();
                    
                    if (curr.left != null)
                    {
                        nodes.Enqueue(curr.left);
                    }
    
                    if (curr.right != null)
                    {
                        nodes.Enqueue(curr.right);
                    }
                }
    
                levels++;
            }
    
            return levels;
        }
    }
    public class MaximumDepthofBinaryTree
    {
        [Fact]
        public void MaximumDepthofBinaryTree_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}