namespace LeetCode_Practice
{
    public partial class Solution {

        public int GetDecimalValue(ListNode<int> head) {
            int count = -1;
            int result = 0;
    
            Queue<int> set = new Queue<int>();
    
            while (head != null)
            {
                set.Enqueue(head.val);
                count++;
                head = head.next;
            }
    
            while (set.Any())
            {
                result += set.Dequeue() * (int)Math.Pow(2, count);
                count--;
            }
    
            return result;
        }
    }
    public class ConvertBinaryNumberinaLinkedListtoInteger
    {
        [Fact]
        public void ConvertBinaryNumberinaLinkedListtoInteger_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(5, solution.GetDecimalValue());
        }
    }
}