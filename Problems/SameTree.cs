namespace LeetCode_Practice
{
    public partial class Solution {
        public bool sameResult;
        public bool IsSameTree(TreeNode<int> p, TreeNode<int> q) {
            if ((p == null && q != null) || (p != null && q == null))
            {
                return false;
            }

            if(p == null && q == null)
            {
                return true;
            }

            if (p.val != q.val)
            {
                return false;
            }

            var left = IsSameTree(p.left, q.left);

            //checking right
            var right = IsSameTree(p.right, q.right);

            return left && right;
        }
    }
    public class SameTree
    {
        [Fact]
        public void SameTree_Case1()
        {
            Solution solution = new Solution();
            TreeNode<int> p = new TreeNode<int>(1);
            p.left = new TreeNode<int>(2);
            p.right = new TreeNode<int>(3);
            
            TreeNode<int> q = new TreeNode<int>(1);
            q.left = new TreeNode<int>(2);
            q.right = new TreeNode<int>(3);
            
            Assert.True(solution.IsSameTree(p, q));
        }
        [Fact]
        public void SameTree_Case2()
        {
            Solution solution = new Solution();
            TreeNode<int> p = new TreeNode<int>(1);
            p.left = new TreeNode<int>(2);
            p.right = new TreeNode<int>(1);
            
            TreeNode<int> q = new TreeNode<int>(1);
            q.left = new TreeNode<int>(1);
            q.right = new TreeNode<int>(2);
            
            Assert.True(solution.IsSameTree(p, q));
        }
    }
}