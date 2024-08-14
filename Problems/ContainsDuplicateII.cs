namespace LeetCode_Practice
{
    public partial class Solution {
        public bool ContainsNearbyDuplicate(int[] nums, int k) {
            Dictionary<int, int> dict = new Dictionary<int,int>();
    
            bool result = false;
    
            for (int i = 0; i < nums.Length; i++)
            {
                if (dict.ContainsKey(nums[i]))
                {
                    result = Math.Abs(dict[nums[i]] - i) <= k;
    
                    if (result == true)
                    {
                        break;
                    }
                    else
                    {
                        dict[nums[i]] = i;
                    }
                }
                else
                {
                    dict.Add(nums[i],i);
                }
            }
    
            return result;
        }
    }
    public class ContainsDuplicateII
    {
        [Fact]
        public void ContainsDuplicateII_Case1()
        {
            Solution solution = new Solution();
            Assert.True(solution.ContainsNearbyDuplicate(nums: [1,2,3,1], k: 3));
        }
    }
}