namespace LeetCode_Practice
{
    public partial class Solution {
        public TreeNode<int> newRoot = null;
        public TreeNode<int> temp = null;
        public TreeNode<int> IncreasingBST(TreeNode<int> root) {
            if (root is null)
            {
                return newRoot;
            }

            IncreasingBST(root.left);
            if(temp == null)
            {
                newRoot = root;
                temp = root;
            }
            else
            {
                temp.right = root;
                temp = root;
                temp.left = null;
            }
            IncreasingBST(root.right);

            return newRoot;
        
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
                    left = new TreeNode<int>(2)
                    {
                        left = new TreeNode<int>(1)
                    },
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