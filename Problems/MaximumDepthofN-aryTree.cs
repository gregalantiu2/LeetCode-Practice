namespace LeetCode_Practice
{
    public partial class Solution {
        public int MaxDepth(Node root) {
            int depth = 0;
    
            if (root == null)
            {
                return depth;
            }
    
            Queue<Node> q = new Queue<Node>();
    
            q.Enqueue(root);
    
            while (q.Count > 0)
            {
                int levelLength = q.Count;
    
                for (int i = 0; i < levelLength; i++)
                {
                    var curr = q.Dequeue();
    
                    foreach (var child in curr.children)
                    {
                        q.Enqueue(child);
                    }
                }
    
                depth++;
            }
    
            return depth;
        }
    }
    public class MaximumDepthofNaryTree
    {
        [Fact]
        public void MaximumDepthofNaryTree_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}