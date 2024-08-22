namespace LeetCode_Practice
{
    public partial class Solution {
        public int FindComplement(int num) {
            var binaryCharArray = Convert.ToString(num, 2).ToCharArray();

            for (int i = 0; i < binaryCharArray.Length; i++)
            {
                binaryCharArray[i] = binaryCharArray[i] == '0' ? '1' : '0';  
            }

            return Convert.ToInt32(new string(binaryCharArray), 2);
        }
    }
    public class NumberComplement
    {
        [Fact]
        public void NumberComplement_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(2, solution.FindComplement(num: 5));
        }
        [Fact]
        public void NumberComplement_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(0, solution.FindComplement(num: 1));
        }
    }
}