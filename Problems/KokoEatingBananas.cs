namespace LeetCode_Practice
{
    public partial class Solution
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            int left = 1;
            int right = piles.Max();
            int answer = right;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                double hoursToEat = 0;

                foreach (var pile in piles)
                {
                    hoursToEat += Math.Ceiling((double) pile / mid);
                }

                if (hoursToEat > h)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return left;  
        }
    }
    public class KokoEatingBananas
    {
        [Fact]
        public void KokoEatingBananas_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(4, solution.MinEatingSpeed([3,6,7,11], 8));
        }
    }
}