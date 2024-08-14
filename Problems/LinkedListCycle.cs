namespace LeetCode_Practice
{
    public partial class Solution {
        Dictionary<ListNode<int>, int> tracker = new Dictionary<ListNode<int>,int>();
    
        public bool HasCycle(ListNode<int> head) {
            if (head is null)
                return false;
    
            if (tracker.ContainsKey(head))
            {
                return true;
            }    
            else
            {
                tracker.Add(head, 1);
            }
    
            return HasCycle(head.next);
        }
    }
    public class LinkedListCycle
    {
        [Fact]
        public void LinkedListCycle_Case1()
        {
            Solution solution = new Solution();
        }
    }
}