namespace LeetCode_Practice
{   
      public class ListNode {
          public int val;
          public ListNode next;
          public ListNode(int val=0, ListNode next=null) {
              this.val = val;
              this.next = next;
          }
      }

    public partial class Solution {

        public ListNode ReverseList(ListNode head) {
            ListNode previousNode = null;
            ListNode nextNode = null;
    
            while(head != null)
            {
                //Save next Node
                nextNode = head.next;
    
                //Change current node to point to previous node then update previous node to current node
                head.next = previousNode;
                previousNode = head;
    
                //Iterate to next node
                head = nextNode;
            }
    
            return previousNode;
        }
        private ListNode previousNode2 { get; set; } = null;

        public ListNode ReverseList_Recursive(ListNode head)
        {
            if (head is null )
            {
                return head;
            }

            ListNode previousNode = null;
            ListNode saveNext = head.next;

            head.next = previousNode2;

            previousNode2 = head;

            ReverseList_Recursive(saveNext);

            return previousNode2;
        }
    }
    public class ReverseLinkedList
    {
        [Fact]
        public void ReverseLinkedList_Case1()
        {

        }
    }
}