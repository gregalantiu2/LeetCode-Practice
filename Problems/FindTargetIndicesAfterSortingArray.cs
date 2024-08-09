namespace LeetCode_Practice
{
    public partial class Solution {
        public IList<int> TargetIndices(int[] nums, int target) {
            List<int> indices = new List<int>();
    
            Array.Sort(nums);
    
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    indices.Add(i);
                }
            }
    
            return indices;
        }
    }
    public class FindTargetIndicesAfterSortingArray
    {
        [Fact]
        public void FindTargetIndicesAfterSortingArray_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([1,2], solution.TargetIndices(nums: [1,2,5,2,3], target: 2));
        }
        [Fact]
        public void FindTargetIndicesAfterSortingArray_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal([3], solution.TargetIndices(nums: [1,2,5,2,3], target: 3));
        }
        [Fact]
        public void FindTargetIndicesAfterSortingArray_Case3()
        {
            Solution solution = new Solution();
            Assert.Equal([4], solution.TargetIndices(nums: [1,2,5,2,3], target: 5));
        }
    }
}