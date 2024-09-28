namespace LeetCode_Practice
{
    public partial class Solution {
        public int[] ToArray(DoubleListNode<int> head) {
            List<int> result = new List<int>();
    
            while (head != null)
            {
                result.Add(head.val);
                head = head.next;
            }
    
            return result.ToArray();
        }
    }
    public class ConvertDoublyLinkedListtoArrayI
    {
        [Fact]
        public void ConvertDoublyLinkedListtoArrayI_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}