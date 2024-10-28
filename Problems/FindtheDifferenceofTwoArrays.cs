namespace LeetCode_Practice
{
    public partial class Solution {
        public IList<IList<int>> FindDifference(int[] nums1, int[] nums2) {
            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = new HashSet<int>(nums2);
    
            foreach (var num in set1)
            {
                if (set2.Contains(num))
                {
                    set1.Remove(num);
                    set2.Remove(num);
                }
            }
    
            return new List<IList<int>>() { set1.ToList(), set2.ToList() };
        }
    }
    public class FindtheDifferenceofTwoArrays
    {
        [Fact]
        public void FindtheDifferenceofTwoArrays_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal([[1,3],[4,6]], solution.IList<IList<int>> FindDifference(nums1: [1,2,3], nums2: [2,4,6]));
        }
        [Fact]
        public void FindtheDifferenceofTwoArrays_Case2()
        {
            Solution solution = new Solution();
            //Assert.Equal([[3],[]], solution.IList<IList<int>> FindDifference(nums1: [1,2,3,3], nums2: [1,1,2,2]));
        }
    }
}