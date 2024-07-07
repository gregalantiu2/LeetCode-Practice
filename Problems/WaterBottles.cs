namespace LeetCode_Practice
{
    public partial class Solution {
        public int NumWaterBottles(int numBottles, int numExchange) {
            int bottleCount = numBottles;

            while (numBottles >= numExchange)
            {
                bottleCount += numBottles / numExchange;
                numBottles = (numBottles / numExchange) + (numBottles % numExchange); 
            }

            return bottleCount;
        }
    }
    public class WaterBottles
    {
        [Fact]
        public void WaterBottles_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(13, solution.NumWaterBottles(numBottles: 9, numExchange: 3));
        }
        [Fact]
        public void WaterBottles_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(19, solution.NumWaterBottles(numBottles: 15, numExchange: 4));
        }
    }
}