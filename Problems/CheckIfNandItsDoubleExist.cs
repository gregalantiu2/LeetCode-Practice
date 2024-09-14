namespace LeetCode_Practice
{
    public partial class Solution {
        public bool CheckIfExist(int[] arr) {
            bool result = false;
            for (int i = 0; i < arr.Length; i++)
            {
                int j = 0;
                while (j < arr.Length)
                {
                    if (j != i && arr[i] == 2 * arr[j])
                    {
                        return true;
                    }
                    else{
                        j++;
                    }
                }
            }
    
            return result;
        }
    }
    public class CheckIfNandItsDoubleExist
    {
        [Fact]
        public void CheckIfNandItsDoubleExist_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(true, solution.CheckIfExist(arr: [10,2,5,3]));
        }
        [Fact]
        public void CheckIfNandItsDoubleExist_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(false, solution.CheckIfExist(arr: [3,1,7,11]));
        }
    }
}