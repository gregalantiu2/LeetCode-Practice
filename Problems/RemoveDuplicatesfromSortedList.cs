namespace LeetCode_Practice
{
    public partial class Solution {
        public ListNode<int> DeleteDuplicates(ListNode<int> head) {
            if (head is null)
                return null;
            
            ListNode<int> ptr = head;
    
            while(ptr.next != null)
            {
                if (ptr.val == ptr.next.val)
                {
                    ptr.next = ptr.next.next;
                }
                else{
                    ptr = ptr.next;
                }
            }
    
            return head;
        }
    }
    public class RemoveDuplicatesfromSortedList
    {
        [Fact]
        public void RemoveDuplicatesfromSortedList_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}