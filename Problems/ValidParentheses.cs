using System.Collections;

namespace LeetCode_Practice
{
    public partial class Solution {
        public bool IsValid(string s) {
            Stack<char> parenthesis = new Stack<char>();
            bool valid = true;

            foreach (var c in s.ToCharArray())
            {
                if (!valid)
                    break;
                switch (c)
                {
                    case '(':
                        parenthesis.Push(c);
                        break;
                    case '[':
                        parenthesis.Push(c);
                        break;
                    case '{':
                        parenthesis.Push(c);
                        break;
                    case ')':
                        if (parenthesis.Any() && parenthesis.Peek() == '(')
                            parenthesis.Pop();
                        else
                            valid = false;
                        break;
                    case ']':
                        if (parenthesis.Any() && parenthesis.Peek() == '[')
                            parenthesis.Pop();
                        else
                            valid = false;
                        break;
                    case '}':
                        if (parenthesis.Any() && parenthesis.Peek() == '{')
                            parenthesis.Pop();
                        else
                            valid = false;
                        break;
                }
            }

            if (parenthesis.Any())
                valid = false;

            return valid;
        }
    }
    public class ValidParentheses
    {
        [Fact]
        public void ValidParentheses_Case1()
        {
            Solution solution = new Solution();
            Assert.True(solution.IsValid("()[]{}"));
        }
    }
}