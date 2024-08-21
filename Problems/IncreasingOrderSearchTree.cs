namespace LeetCode_Practice
{
    public partial class Solution {
        public TreeNode<int> IncreasingBST(TreeNode<int> root) {
            if (root is null)
            {
                return null;
            }
    
            IncreasingBST(root.left);
            
            IncreasingBST(root.right);
    
            return root;
        }
    }
    public class IncreasingOrderSearchTree
    {
        [Fact]
        public void IncreasingOrderSearchTree_Case1()
        {
            Solution solution = new Solution();
            TreeNode<int> inputRoot = new TreeNode<int>(5)
            {
                left = new TreeNode<int>(3)
                {
                    left = new TreeNode<int>(2),
                    right = new TreeNode<int>(4)
                },
                right = new TreeNode<int>(6)
                {
                    right = new TreeNode<int>(8)
                    {
                        left = new TreeNode<int>(7),
                        right = new TreeNode<int>(9)
                    }
                }
            };
            
            TreeNode<int> expectedRoot = new TreeNode<int>(1)
            {
                right = new TreeNode<int>(2)
                {
                    right = new TreeNode<int>(3)
                    {
                        right = new TreeNode<int>(4)
                        {
                            right = new TreeNode<int>(5)
                            {
                                right = new TreeNode<int>(6)
                                {
                                    right = new TreeNode<int>(7)
                                    {
                                        right = new TreeNode<int>(8)
                                        {
                                            right = new TreeNode<int>(9)
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
            
            Assert.Equal(expectedRoot, solution.IncreasingBST(inputRoot));
        }
    }
}