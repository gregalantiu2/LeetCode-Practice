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
        public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
            ListNode dummyHead = new ListNode();
            ListNode dummyTail = dummyHead;


            while(list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    dummyTail.next = list1;
                    list1 = list1.next;
                }
                else
                {
                    dummyTail.next = list2;
                    list2 = list2.next;
                }
                dummyTail = dummyTail.next;
            }

            if (list1 != null){
                dummyTail.next = list1;
            }
            else if (list2 != null){
                dummyTail.next = list2;
            }

            return dummyHead.next;
        }
    }
    public class MergeTwoSortedLists
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            ListNode list1 = new ListNode(1);
            list1.next = new ListNode(3);
            list1.next.next = new ListNode(5);

            ListNode list2 = new ListNode(2);
            list2.next = new ListNode(4);
            list2.next.next = new ListNode(6);

            Solution solution = new Solution();

            // Act
            ListNode mergedList = solution.MergeTwoLists(list1, list2);

            // Assert
            Assert.Equal(1, mergedList.val);
            Assert.Equal(2, mergedList.next.val);
            Assert.Equal(3, mergedList.next.next.val);
            Assert.Equal(4, mergedList.next.next.next.val);
            Assert.Equal(5, mergedList.next.next.next.next.val);
            Assert.Equal(6, mergedList.next.next.next.next.next.val);
            Assert.Null(mergedList.next.next.next.next.next.next);
        }
    }
}