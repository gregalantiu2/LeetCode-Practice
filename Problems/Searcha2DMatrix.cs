namespace LeetCode_Practice
{
    public partial class Solution {
        public bool SearchMatrix(int[][] matrix, int target) {
            
    
            for(int i = 0; i < matrix.Length; i++)
            {
                int start = 0;
                int end = matrix[i].Length - 1;
                int mid;
    
                while(start <= end)
                {
                    mid = (start + end) / 2;
    
                    if(target < matrix[i][mid])
                    {
                        end = mid - 1;
                    }
                    else if(target > matrix[i][mid])
                    {
                        start = mid + 1;
                    }
                    else{
                        return true;
                    }
                }
            }
            
            return false;
        }
    }
    public class Searcha2DMatrix
    {
        [Fact]
        public void Searcha2DMatrix_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(X,solution.Test(x));
        }
    }
}