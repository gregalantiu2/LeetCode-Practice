namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] SortedSquares(int[] nums) {
           for (int i = 0; i < nums.Length; i++)
           {
                nums[i] = nums[i] * nums[i];
           }
    
            for (int i = 1; i < nums.Length; i++)
            {
                int j = i - 1;
                while (j >= 0 && nums[j + 1] < nums[j])
                {
                    var temp = nums[j + 1];
                    nums[j + 1] = nums[j];
                    nums[j] = temp;
                    j--;
                }
            }
    
            return nums;
        }

        public int[] SortedSquares2(int[] nums) {
            int left = 0;
            int right = nums.Length - 1;
            int index = nums.Length - 1;

            int[] result = new int[nums.Length];

            while (left <= right)
            {
                int leftSquare = nums[left] * nums[left];
                int rightSquare = nums[right] * nums[right];

                if (leftSquare > rightSquare)
                {
                    result[index] = leftSquare; 
                    left++;
                }
                else{
                    result[index] = rightSquare; 
                    right--;
                }

                index--;
            }

            return result;
        }
    }
    public class SquaresofaSortedArray
    {
        [Fact]
        public void SquaresofaSortedArray_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([0,1,9,16,100], solution.SortedSquares2(nums: [-4,-1,0,3,10]));
        }
    }
}