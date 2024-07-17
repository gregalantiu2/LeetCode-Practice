namespace LeetCode_Practice
{
    public partial class Solution {
        public ListNode<int> RemoveElements(ListNode<int> head, int val) {
            
            if (head == null)
                return null;
            
            head.next = RemoveElements(head.next, val);
    
            return head.val == val ? head.next : head;
        }
    }
    public class RemoveLinkedListElements
    {
        [Fact]
        public void RemoveLinkedListElements_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}