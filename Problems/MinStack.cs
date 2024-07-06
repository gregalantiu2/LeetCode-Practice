namespace LeetCode_Practice
{
    public partial class Solution {    
         public class MinStack {
            Stack<int> stack;
            Stack<int> min;
        
            public MinStack() {
                stack = new Stack<int>();
                min = new Stack<int>();
            }
            
            public void Push(int val) {
                if (!min.Any() || val <= min.Peek())
                    min.Push(val);
                
                stack.Push(val);
            }
            
            public void Pop() {
                if (min.Any() && stack.Peek() == min.Peek())
                    min.Pop();
                stack.Pop();
            }
            
            public int Top() {
                return stack.Peek();
            }
            
            public int GetMin() {
                return min.Peek();
            }
        }
    }
   
    
    public class MinStack
    {
        [Fact]
        public void MinStack_Case1()
        {
            Solution solution = new Solution();
            // Assert.Equal(X,solution.Test(x));
        }
    }
}