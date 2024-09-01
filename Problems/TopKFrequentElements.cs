namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] TopKFrequent(int[] nums, int k) {
            Dictionary<int, int> dict = new Dictionary<int, int>();
    
            foreach (var num in nums)
            {
                if (!dict.ContainsKey(num))
                {
                    dict.Add(num, 1);
                }
                else
                {
                    dict[num]++;
                }
            }
    
            var sortedList = dict.OrderByDescending(x => x.Value).Select(x => x.Key).ToList();
    
            int[] result = new int[k];
    
            for (int i = 0; i < k; i++)
            {
                result[i] = sortedList[i];
            }
    
            return result;
        }
    }
    public class TopKFrequentElements
    {
        [Fact]
        public void TopKFrequentElements_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}