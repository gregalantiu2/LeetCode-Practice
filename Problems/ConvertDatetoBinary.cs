namespace LeetCode_Practice
{
    public partial class Solution {
        public string ConvertDateToBinary(string date) {
            var dateTime = Convert.ToDateTime(date);
    
            return $"{Convert.ToString(dateTime.Year, 2)}-{Convert.ToString(dateTime.Month,2)}-{Convert.ToString(dateTime.Day,2)}";
        }
    }
    "
    "2080-02-29"
    "1900-01-01"
    "100000100000-10-11101"
    "11101101100-1-1"
    "100000100000-10-11101"
    public class ConvertDatetoBinary
    {
        [Fact]
        public void ConvertDatetoBinary_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(X,solution.Test(x));
        }
    }
}