namespace LeetCode_Practice
{
    public partial class Solution {    
        public ListNode<int> MergeTwoLists(ListNode<int> list1, ListNode<int> list2) {
            ListNode<int> dummyHead = new ListNode<int>();
            ListNode<int> dummyTail = dummyHead;


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
            ListNode<int> list1 = new ListNode<int>(1);
            list1.next = new ListNode<int>(3);
            list1.next.next = new ListNode<int>(5);

            ListNode<int> list2 = new ListNode<int>(2);
            list2.next = new ListNode<int>(4);
            list2.next.next = new ListNode<int>(6);

            Solution solution = new Solution();

            // Act
            ListNode<int> mergedList = solution.MergeTwoLists(list1, list2);

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