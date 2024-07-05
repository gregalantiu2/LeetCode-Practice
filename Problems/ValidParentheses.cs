namespace LeetCode_Practice
{
    public partial class Solution {
        public bool IsValid(string s) {
            bool isValid = true;
    
            Stack<char> regular = new Stack<char>();
            Stack<char> square = new Stack<char>();
            Stack<char> curly = new Stack<char>();
    
            foreach (char c in s.ToCharArray())
            {
                if (!isValid)
                    break;
    
                switch (c)
                {
                    case '(':
                        regular.Push(c);
                        break;
                    case ')':
                        if(regular.Count() == 0 || (regular.Count() % 2 == 0 && regular.Peek() == c))
                        {
                            isValid = false;
                            break;
                        }
                        regular.Push(c);
                        break;
                    case '[':
                        square.Push(c);
                        break;
                    case ']':
                        if(square.Count() == 0 || (square.Count() % 2 == 0 && square.Peek() == c))
                        {
                            isValid = false;
                            break;
                        }
                        square.Push(c);
                        break;
                    case '{':
                        curly.Push(c);
                        break;
                    case '}':
                        if(curly.Count() == 0 || (curly.Count() % 2 == 0 && curly.Peek() == c))
                        {
                            isValid = false;
                            break;
                        }
                        curly.Push(c);
                        break;
                    default:
                        break;
                }
            }
    
            if(regular.Count() % 2 !=0 || square.Count() % 2 != 0 || curly.Count() % 2 != 0)
            {
                isValid = false;
            }
    
            return isValid;
        }
    }
    public class ValidParentheses
    {
        [Fact]
        public void ValidParentheses_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(X,solution.Test(x));
        }
    }
}