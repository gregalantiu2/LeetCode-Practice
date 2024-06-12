namespace LeetCode_Practice
{   
    public partial class Solution {

        public ListNode<int> ReverseList(ListNode<int> head) {
            ListNode<int> previousNode = null;
            ListNode<int> nextNode = null;
    
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
        private ListNode<int> previousNode2 { get; set; } = null;

        public ListNode<int> ReverseList_Recursive(ListNode<int> head)
        {
            if (head is null )
            {
                return head;
            }

            ListNode<int> previousNode = null;
            ListNode<int> saveNext = head.next;

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