namespace LeetCode_Practice
{
    public partial class Solution {
        public int CalPoints(string[] operations) {
            Stack<int> record = new Stack<int>();
    
            foreach (var operation in operations)
            {
                switch(operation)
                {
                    case "+":
                        var top = record.Pop();
                        var previous = record.Pop();
                        var sum = top + previous;
    
                        record.Push(previous);
                        record.Push(top);
                        record.Push(sum);
                        break;
                    case "D":
                        record.Push(record.Peek() * 2);
                        break;
                    case "C":
                        record.Pop();
                        break;
                    default:
                        record.Push(int.Parse(operation));
                        break;
                }
            }
    
            return record.Sum();
        }
    }
    public class BaseballGame
    {
        [Fact]
        public void BaseballGame_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(30, solution.CalPoints(operations: ["5","2","C","D","+"]));
        }
        [Fact]
        public void BaseballGame_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(27, solution.CalPoints(operations: ["5","-2","4","C","D","9","+","+"]));
        }
        [Fact]
        public void BaseballGame_Case3()
        {
            Solution solution = new Solution();
            Assert.Equal(0, solution.CalPoints(operations: ["1","C"]));
        }
    }
}