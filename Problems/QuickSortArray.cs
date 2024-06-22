namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] QuickSortArray(int[] nums) {
            return new int[] { };
        }
    }

     
    public class QuickSortArray
    {
        [Fact]
        public void QuickSortanArray_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([1,2,3,5], solution.QuickSortArray(nums: [5,2,3,1]));
        }
        [Fact]
        public void QuickSortanArray_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal([0,0,1,1,2,5], solution.QuickSortArray(nums: [5,1,1,2,0,0]));
        }
        [Fact]
        public void QuickSortanArray_Case3()
        {
            Solution solution = new Solution();
            Assert.Equal([-5,-2,3], solution.QuickSortArray(nums: [-2,3,-5]));
        }
    }
}