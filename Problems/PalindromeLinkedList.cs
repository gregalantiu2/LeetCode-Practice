namespace LeetCode_Practice
{
    public partial class Solution {
        public bool IsPalindrome(ListNode<int> head) {
            Stack<int> set1 = new Stack<int>();
            Queue<int> set2 = new Queue<int>();
     
            ListNode<int> node = head;
    
            while (head != null)
            {
                set1.Push(head.val);
                set2.Enqueue(head.val);
                head = head.next;
            }
    
            while (set1.Any())
            {
                if (set1.Pop() != set2.Dequeue())
                    return false;
            }
    
            return true;
    
        }
    }
    public class PalindromeLinkedList
    {
        [Fact]
        public void PalindromeLinkedList_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}