namespace LeetCode_Practice
{
    public partial class Solution
    {
        public int[] SearchRange(int[] nums, int target)
        {
            int[] result = [-1, -1];

            var left = 0;
            var right = nums.Length - 1;

            while (left <= right)
            {
                var mid = left + (right - left) / 2;

                if (target < nums[mid])
                {
                    right = mid - 1;
                }
                else if (target > nums[mid])
                {
                    left = mid + 1;
                }
                else
                {
                    result = [mid, mid];

                    while (mid != nums.Length - 1 && nums[mid + 1] == target)
                    {
                        result[1] = mid + 1;
                        mid++;
                    }

                    while (mid != 0 && nums[mid - 1] == target)
                    {
                        result[0] = mid - 1;
                        mid--;
                    }

                    return result;
                }
            }

            return result;
        }

        public int[] SearchRange2(int[] nums, int target)
        {
            int[] result = new int[2];

            int startIndex = 0;
            int endIndex = nums.Length - 1;

            result[0] = this.SearchIndex(nums, target, startIndex, endIndex, true);

            if (result[0] == -1)
            {
                result[1] = -1;
                return result;
            }


            result[1] = this.SearchIndex(nums, target, result[0], endIndex, false);

            return result;
        }

        public int SearchIndex(int[] nums, int target, int startIndex, int endIndex, bool isFirst)
        {
            while (startIndex <= endIndex)
            {
                int mid = startIndex + (endIndex - startIndex) / 2;

                if (nums[mid] == target)
                {
                    if (isFirst)
                    {
                        if (mid != 0 && nums[mid - 1] == target)
                        {
                            endIndex = mid - 1;
                        }
                        else
                        {
                            return mid;
                        }
                    }
                    else
                    {
                        if (mid != nums.Length - 1 && nums[mid + 1] == target)
                        {
                            startIndex = mid + 1;
                        }
                        else
                        {
                            return mid;
                        }
                    }
                }
                else if (target < nums[mid])
                {
                    endIndex = mid - 1;
                }
                else
                {
                    startIndex = mid + 1;
                }
            }

            return -1;
        }
    }
    public class FindFirstandLastPositionofElementinSortedArray
    {
        [Fact]
        public void FindFirstandLastPositionofElementinSortedArray_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([3, 4], solution.SearchRange([5, 7, 7, 8, 8, 10], 8));
        }
        [Fact]
        public void FindFirstandLastPositionofElementinSortedArray_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal([3, 4], solution.SearchRange2([5, 7, 7, 8, 8, 10], 8));
        }
    }
}

