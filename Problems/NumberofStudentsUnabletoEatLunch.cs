namespace LeetCode_Practice
{
    public partial class Solution {
        public int CountStudents(int[] students, int[] sandwiches) {
            Queue<int> studentQueue = new Queue<int>(students);
            Stack<int> sandwichStack = new Stack<int>(sandwiches.Reverse());

            while(studentQueue.Count() > 0 && studentQueue.Contains(sandwichStack.Peek()))
            {
                var frontStudent = studentQueue.Dequeue();
                if (frontStudent == sandwichStack.Peek())
                {
                    sandwichStack.Pop();
                }
                else{
                    //Move student to the back of the line
                    studentQueue.Enqueue(frontStudent); 
                }
            }

            return studentQueue.Count();
        }
    }
    public class NumberofStudentsUnabletoEatLunch
    {
        [Fact]
        public void NumberofStudentsUnabletoEatLunch_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(0, solution.Queue.Count(students: [1,1,0,0], sandwiches: [0,1,0,1]));
        }
    }
}