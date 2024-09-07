namespace LeetCode_Practice
{
    public partial class Solution {
        public int ThirdMax(int[] nums) {
            Array.Sort(nums);
    
            List<int> set = new List<int>();
    
            foreach (var num in nums)
            {
                if(!set.Contains(num))
                {
                    set.Add(num);
                }
            }
    
            if (set.Count < 3)
            {
                return set[set.Count - 1];
            }
    
            return set[set.Count - 3];
        }
    }
    public class ThirdMaximumNumber
    {
        [Fact]
        public void ThirdMaximumNumber_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(1, solution.ThirdMax(nums: [3,2,1]));
        }
        [Fact]
        public void ThirdMaximumNumber_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(2, solution.ThirdMax(nums: [1,2]));
        }
        [Fact]
        public void ThirdMaximumNumber_Case3()
        {
            Solution solution = new Solution();
            Assert.Equal(1, solution.ThirdMax(nums: [2,2,3,1]));
        }
    }
}