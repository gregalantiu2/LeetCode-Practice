namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] Intersection(int[] nums1, int[] nums2) {
            HashSet<int> hash1 = new HashSet<int>();
            HashSet<int> hash2 = new HashSet<int>();
    
            foreach (var num in nums1)
            {
                if (!hash1.Contains(num))
                {
                    hash1.Add(num);
                }
            }
    
            foreach (var num in nums2)
            {
                if (hash1.Contains(num) && !hash2.Contains(num))
                {
                    hash2.Add(num);
                }
            }
    
            return hash2.ToArray();
        }
    }
    public class IntersectionofTwoArrays
    {
        [Fact]
        public void IntersectionofTwoArrays_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([9,4], solution.Intersection(nums1: [4,9,5], nums2: [9,4,9,8,4]));
        }
    }
}