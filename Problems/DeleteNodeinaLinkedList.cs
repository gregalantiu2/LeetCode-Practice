namespace LeetCode_Practice
{
    public partial class Solution {
        public void DeleteNode(ListNode<int> node) {
            
            while (node != null)
            {
                node.val = node.next.val;
                if (node.next.next == null)
                {
                    node.next = null;
                    break;
                }
                else{
                    node = node.next;
                }
            }
        }
    }
    public class DeleteNodeinaLinkedList
    {
        // [Fact]
        // public void DeleteNodeinaLinkedList_Case1()
        // {
        //     Solution solution = new Solution();
        //     Assert.Equal([4,1,9], solution.DeleteNode(head: [4,5,1,9], node: 5));
        // }
        // [Fact]
        // public void DeleteNodeinaLinkedList_Case2()
        // {
        //     Solution solution = new Solution();
        //     Assert.Equal([4,5,9], solution.DeleteNode(head: [4,5,1,9], node: 1));
        // }
    }
}