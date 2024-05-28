namespace LeetCode_Practice
{
    /**
     * Definition for singly-linked list.
     * public class ListNode {
     *     public int val;
     *     public ListNode next;
     *     public ListNode(int val=0, ListNode next=null) {
     *         this.val = val;
     *         this.next = next;
     *     }
     * }
     */
    public partial class Solution {
        ListNode modifiedList;
    
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
            // Modify one sorted list - modify the one with the lowest val
            //Compare list val
            //  If val is lower or equal, make it next
            // Take the next correct value and make it next to the current node
            //return head
    
            // base case: 
            if (list1 == null && list2 == null)
            {
                return null;
            }
            else
            {
                if (list1 != null && list2 == null)
                {
                    if (modifiedList == null)
                    {
                        modifiedList = list1;
                    }
                    else {
                        modifiedList.next = list1;
                    }
                }   
    
                else if (list2 != null && list1 == null)
                {
                    if (modifiedList == null)
                    {
                        modifiedList = list2;
                    }
                    else {
                        modifiedList.next = list2;
                    }
                }
                else
                {
                    if (modifiedList == null)
                    {
                        modifiedList = list1.val <= list2.val ? list1 : list2;
                    }
                    else
                    {
                        modifiedList.next = list1.val <= list2.val ? list1 : list2;
                    }
                }
                
            }
    
            MergeTwoLists(list1?.next, list2?.next);
    
            return modifiedList;
        }
    }
    public class MergeTwoSortedLists
    {
        [Fact]
        public void MergeTwoSortedLists_Case1()
        {
            Solution solution = new Solution();
            solution.MergeTwoLists(null, new ListNode() { val = 2, next = null });
            Assert.Equal(1,1);
        }
    }
}