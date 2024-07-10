namespace LeetCode_Practice
{
    public partial class Solution {
        public int MinOperations(string[] logs) {
            Stack<int> operations = new Stack<int>();
    
            foreach (var log in logs)
            {
                switch (log)
                {
                    case "../":
                        if(operations.Any())
                            operations.Pop();
                        break;
                    case "./":
                        break;
                    default:
                        operations.Push(1);
                        break;
                }   
            }
    
            if(!operations.Any())
                return 0;
    
            return operations.Count();
        }
    }
    public class CrawlerLogFolder
    {
        [Fact]
        public void CrawlerLogFolder_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(2, solution.MinOperations(logs: ["d1/","d2/","../","d21/","./"]));
        }
    }
}