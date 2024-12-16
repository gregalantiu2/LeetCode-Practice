namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] GetFinalState(int[] nums, int k, int multiplier) {
            if (nums.Length < 1)
            {
                return nums;
            }
            
            for (int i = 0; i < k; i++)
            {
                var minIndex = GetIndexOfMinimum(nums);
                nums[minIndex] = nums[minIndex] * multiplier; 
            }
    
            return nums;
        }
    
        internal int GetIndexOfMinimum(int[] arr)
        {
            int minValue = arr[0];
            int index = 0;
    
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                    index = i;
                }
            }
    
            return index;
        }
    }
    public class FinalArrayStateAfterKMultiplicationOperationsI
    {
        [Fact]
        public void FinalArrayStateAfterKMultiplicationOperationsI_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}