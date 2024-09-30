namespace LeetCode_Practice
{
    public partial class Solution {
        public void PrintLinkedListInReverse(ImmutableListNode head) {
            if (head.GetNext() != null)
            {
                PrintLinkedListInReverse(head.GetNext());
            }
            head.PrintValue();
        }
    }
    public class PrintImmutableLinkedListinReverse
    {
        [Fact]
        public void PrintImmutableLinkedListinReverse_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}