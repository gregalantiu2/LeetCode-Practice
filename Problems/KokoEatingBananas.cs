namespace LeetCode_Practice
{
    public partial class Solution
    {
        public int MinEatingSpeed(int[] piles, int h)
        {
            for (int i = 1; i <= piles.Max(); i++)
            {
                int hoursToEatPile = 0;
                foreach (var pile in piles)
                {
                    if (pile % i > 0)
                    {
                        hoursToEatPile += pile / i + 1;
                    }
                    else
                    {
                        hoursToEatPile += pile / i;
                    }


                    if (hoursToEatPile > h)
                    {
                        break;
                    }
                }

                if (hoursToEatPile <= h)
                {
                    return i;
                }
            }

            return -1;
        }
    }
    public class KokoEatingBananas
    {
        [Fact]
        public void KokoEatingBananas_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(X, solution.Test(x));
        }
    }
}