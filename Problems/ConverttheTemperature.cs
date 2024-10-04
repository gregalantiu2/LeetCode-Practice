namespace LeetCode_Practice
{
    public partial class Solution {
        public double[] ConvertTemperature(double celsius) {
            return new double[2] { celsius + 273.15, celsius * 1.80 + 32.00 };
        }
    }
    public class ConverttheTemperature
    {
        [Fact]
        public void ConverttheTemperature_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([309.65000,97.70000], solution.ConvertTemperature(celsius: 36.50));
        }
        [Fact]
        public void ConverttheTemperature_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal([395.26000,251.79800], solution.ConvertTemperature(celsius: 122.11));
        }
    }
}