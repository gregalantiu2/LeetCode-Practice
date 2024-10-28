namespace LeetCode_Practice
{
    public partial class Solution {
        public int LargestAltitude(int[] gain) {
            int highest = 0;
            int cumulative = 0;
    
            for (int i = 0; i < gain.Length; i++)
            {
                cumulative += gain[i];
                highest = Math.Max(highest, cumulative);
            }   
    
            return highest;
        }
    }
    public class FindtheHighestAltitude
    {
        [Fact]
        public void FindtheHighestAltitude_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(1, solution.LargestAltitude(gain: [-5,1,5,0,-7]));
        }
        [Fact]
        public void FindtheHighestAltitude_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(0, solution.LargestAltitude(gain: [-4,-3,-2,-1,4,3,2]));
        }
    }
}