namespace LeetCode_Practice
{
    public partial class Solution {
        public void SortColors(int[] nums) 
        {
            int[] counts = {0,0,0};

            //Find frequency
            foreach(var num in nums)
            {
                counts[num] += 1;
            }


            int m = 0; //Track where we are in og array

            //Loop counts array
            for(int j = 0; j < counts.Length; j++)
            {
                //Loop each each frequency
                for(int n = 0; n < counts[j]; n++)
                {
                    nums[m] = j;
                    m++;
                }
            }
        }
    }
    public class SortColors
    {
        [Fact]
        public void SortColors_Case1()
        {
            Solution solution = new Solution();
            solution.SortColors([2,0,2,1,1,0]);
        }
    }
}