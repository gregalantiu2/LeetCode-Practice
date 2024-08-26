namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] MoveZeroes(int[] nums) {
            int j = 0; // Pointer for non-zero elements
    
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] != 0)
                {
                    // Swap non-zero element with the element at index j
                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
    
                    // Increment j to point to the next non-zero element
                    j++;
                }
            }

            return nums;
        }
    }
    public class MoveZeroes
    {
        [Fact]
        public void MoveZeroes_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([1,3,12,0,0], solution.MoveZeroes(nums: [0,1,0,3,12]));
        }

        [Fact]
        public void MoveZeroes_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal([1,1,3,12,0,0], solution.MoveZeroes(nums: [1,1,0,3,0,12]));
        }
    }
}