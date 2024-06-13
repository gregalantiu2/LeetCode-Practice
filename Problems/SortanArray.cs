namespace LeetCode_Practice
{
                //if it is not, do nothing
                //compare each element to last
                //if it is less than, switch and keep going
            {
                int j = i;
                while(nums[j] < nums[j -1])
                {
                    var temp = nums[j - 1];
                    nums[j - 1] = nums[j];
                    nums[j] = temp;
                    
                    //if j is equal to 1, end
                    if(j == 1)
                    {
                        break;
                    }
                    
                    j--;
                }
            }
            return nums;
        }
    }
            for(int i = 1; i < nums.Length; i++)
            //iterate over every element
    public class SortanArray
    {
        [Fact]
        public void SortanArray_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal([1,2,3,5], solution.(nums: [5,2,3,1]));
        }
        [Fact]
        public void SortanArray_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal([0,0,1,1,2,5], solution.(nums: [5,1,1,2,0,0]));
        }
    }
}