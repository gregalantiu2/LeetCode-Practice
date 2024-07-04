
namespace LeetCode_Practice
{
    public partial class Solution
    {
        public int FirstBadVersion(int n)
        {
            int mid;
            int left = 1;
            int right = n;

            while (left <= right)
            {
                mid = left + (right - left) / 2;

                if (IsBadVersion(mid) == true)
                {
                    int previous = mid - 1;
                    if (IsBadVersion(previous) == false)
                        return mid;
                    right = previous;
                }
                else if (IsBadVersion(mid) == false)
                {
                    int next = mid + 1;
                    if (IsBadVersion(next) == true)
                        return next;
                    left = next;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }

        private bool IsBadVersion(int next)
        {
            throw new NotImplementedException();
        }


        [Fact]
        public void FirstBadVersion_Case1()
        {

        }
    }
}