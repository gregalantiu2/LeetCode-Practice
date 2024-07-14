namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] SearchRange(int[] nums, int target) {
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
                    else{
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
        }
    }
    public class FindFirstandLastPositionofElementinSortedArray
    {
        [Fact]
        public void FindFirstandLastPositionofElementinSortedArray_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([3,4],solution.SearchRange([5,7,7,8,8,10], 8));
        }
    }
}