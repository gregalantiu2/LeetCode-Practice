namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] MergeSortArray(int[] nums) {
            return MergeSorting(nums, 0, nums.Length - 1);
        }

        public static int[] MergeSorting(int[] arr, int l, int r)
        {
            // array, starting index of array, last index of array
            if (l < r)
            {
                // Find the middle point of arr
                int m = (l + r) / 2;
                MergeSorting(arr, l, m);   // sort left half
                MergeSorting(arr, m + 1, r); // sort right half
                Merge(arr, l, m, r);    // merge sorted halfs
            }
            return arr;
        }

        public static void Merge(int[] arr, int l, int m, int r)
        {

            // Find lengths of two subarrays to be merged
            int leftLength = m - l + 1;
            int rightLength = r - m;

            // Create temp arrays 
            var tempLeft = new int[leftLength];
            var tempRight = new int[rightLength];

            // Copy the sorted left & right halfs to temp arrays
            for (int a = 0; a < leftLength; a++)
            {
                tempLeft[a] = arr[l + a];
            }

            for (int b = 0; b < rightLength; b++)
            {
                tempRight[b] = arr[m + 1 + b];
            }

            // initial indexes of left and right sub-arrays
            int i = 0; // index for left
            int j = 0; // index for right
            int k = l; // Initial index of merged subarray array

            // Merge the two sorted halfs into the original array
            while (i < leftLength && j < rightLength)
            {
                if (tempLeft[i] <= tempRight[j])
                {
                    arr[k] = tempLeft[i];
                    i++;
                }
                else
                {
                    arr[k] = tempRight[j];
                    j++;
                }
                k++;
            }
            // One of the halfs will have elements remaining

            // Copy remaining elements of L[] if any 
            while (i < leftLength)
            {
                arr[k] = tempLeft[i];
                i++;
                k++;
            }

            // Copy remaining elements of R[] if any 
            while (j < rightLength)
            {
                arr[k] = tempRight[j];
                j++;
                k++;
            }
        }  
    }

     
    public class MergeSortArray
    {
        [Fact]
        public void MergeSortanArray_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([1,2,3,5], solution.MergeSortArray(nums: [5,2,3,1]));
        }
        [Fact]
        public void MergeSortanArray_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal([0,0,1,1,2,5], solution.MergeSortArray(nums: [5,1,1,2,0,0]));
        }
    }
}