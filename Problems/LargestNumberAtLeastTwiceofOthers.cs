namespace LeetCode_Practice
{
    public partial class Solution {
        public int DominantIndex(int[] nums) {
            Dictionary<int,int> dict = new Dictionary<int,int>();
    
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dict.ContainsKey(nums[i]))
                {
                    dict.Add(nums[i], i);
                }
            }
    
            Array.Sort(nums, (a,b) => b.CompareTo(a));
    
            return nums[0] >= nums[1] * 2 ? dict[nums[0]] : -1;  
        }

        public int DominantIndex2(int[] nums) {
            int max = nums.Max();

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != max && nums[i] * 2 > max)
                {
                    return -1;
                }
            }

            return Array.IndexOf(nums, max); 
        }
    }
    public class LargestNumberAtLeastTwiceofOthers
    {
        [Fact]
        public void LargestNumberAtLeastTwiceofOthers_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(1, solution.DominantIndex(nums: [3,6,1,0]));
        }
        [Fact]
        public void LargestNumberAtLeastTwiceofOthers_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(-1, solution.DominantIndex(nums: [1,2,3,4]));
        }
    }
}