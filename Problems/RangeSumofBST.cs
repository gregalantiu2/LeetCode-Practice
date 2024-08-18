namespace LeetCode_Practice
{
    public partial class Solution {
        public int rangeSumResult = 0;

        public int RangeSumBST(TreeNode<int> root, int low, int high) {
            if (root is null)
                return 0;
    
            RangeSumBST(root.left, low, high);
            
            if (root.val >= low && root.val <= high)
            {
                rangeSumResult += root.val;
            }
    
            RangeSumBST(root.right, low, high);
    
            return rangeSumResult;
        }
    
    }
    public class RangeSumofBST
    {
        [Fact]
        public void RangeSumofBST_Case1()
        {
            Solution solution = new Solution();
            TreeNode<int> root = new TreeNode<int>(10)
            {
                left = new TreeNode<int>(5)
                {
                    left = new TreeNode<int>(3),
                    right = new TreeNode<int>(7)
                },
                right = new TreeNode<int>(15)
                {
                    right = new TreeNode<int>(18)
                }
            };
            
            Assert.Equal(32, solution.RangeSumBST(root, low: 7, high: 15));
        }
        [Fact]
        public void RangeSumofBST_Case2()
        {
            Solution solution = new Solution();
            TreeNode<int> root = new TreeNode<int>(10)
            {
                left = new TreeNode<int>(5)
                {
                    left = new TreeNode<int>(3),
                    right = new TreeNode<int>(7)
                    {
                        left = new TreeNode<int>(6)
                    }
                },
                right = new TreeNode<int>(15)
                {
                    left = new TreeNode<int>(13),
                    right = new TreeNode<int>(18)
                    {
                        left = new TreeNode<int>(1)
                    }
                }
            };
            
            Assert.Equal(23, solution.RangeSumBST(root, low: 6, high: 10));
        }
    }
}