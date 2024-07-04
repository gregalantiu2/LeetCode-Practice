
namespace LeetCode_Practice
{
    public partial class Solution {

        public int GuessNumber(int n) {
            int mid;
            int left = 1;
            int right = n;

            while(left <= right)
            {
                mid = left + (right - left) / 2;

                if (guess(mid) == -1)
                {
                    right = mid - 1;
                }
                else if (guess(mid) == 1)
                {
                    left = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        private int guess(int mid)
        {
            throw new NotImplementedException();
        }

    }
    public class GuessNumberHigherorLower
    {
        [Fact]
        public void GuessNumberHigherorLower_Case1()
        {
            
        }
    }
}