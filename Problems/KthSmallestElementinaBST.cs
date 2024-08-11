namespace LeetCode_Practice
{
    public partial class Solution {
        private List<int> result = new List<int>();
    
        public int KthSmallest(TreeNode<int> root, int k) {
            if (root == null)
                return result.Count();
    
            KthSmallest(root.left, k);
            result.Add(root.val);
            KthSmallest(root.right, k);
    
            return k - 1 >= result.Count() ? result.Count() : result[k - 1]; 
        }
    }
    public class KthSmallestElementinaBST
    {
        [Fact]
        public void KthSmallestElementinaBST_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}