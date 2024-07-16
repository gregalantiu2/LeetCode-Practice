namespace LeetCode_Practice
{
    public partial class Solution {
        public string GameResult(ListNode<int> head) {
            int evenScore = 0;
            int oddScore = 0;
    
            while (head != null)
            {
                if (head.val > head.next.val)
                {
                    evenScore++;
                }
                else{
                    oddScore++;
                }
    
                head = head.next.next;
            }
    
            if(evenScore > oddScore)
            {
                return "Even";
            }
            else if (oddScore > evenScore)
            {
                return "Odd";
            }
            else{
                return "Tie";
            }
    
            return "";
        }
    }
    public class WinneroftheLinkedListGame
    {
        [Fact]
        public void WinneroftheLinkedListGame_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}