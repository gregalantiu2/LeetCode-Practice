namespace LeetCode_Practice
{
    public partial class Solution {
        public int MinMovesToSeat(int[] seats, int[] students) {
            for (int i = 1; i < seats.Length; i++)
            {
                int j = i - 1;
                while (j >= 0 && seats[j + 1] < seats[j])
                {
                    var tmp = seats[j];
                    seats[j] = seats[j + 1];
                    seats[j + 1] = tmp;
                    j--;
                }
            }

            for (int i = 1; i < students.Length; i++)
            {
                int j = i - 1;
                while (j >= 0 && students[j + 1] < students[j])
                {
                    var tmp = students[j];
                    students[j] = students[j + 1];
                    students[j + 1] = tmp;
                    j--;
                }
            }

            var totalMoves = 0;

            for (int s = 0; s < seats.Length; s++)
            {
                totalMoves += Math.Abs(students[s] - seats[s]);
            }

            return totalMoves;
        }
    }
    public class MinimumNumberofMovestoSeatEveryone
    {
        [Fact]
        public void MinimumNumberofMovestoSeatEveryone_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(4, solution.MinMovesToSeat(seats: [3,1,5], students: [2,7,4]));
        }
        [Fact]
        public void MinimumNumberofMovestoSeatEveryone_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(7, solution.MinMovesToSeat(seats: [4,1,5,9], students: [1,3,2,6]));
        }
        [Fact]
        public void MinimumNumberofMovestoSeatEveryone_Case3()
        {
            Solution solution = new Solution();
            Assert.Equal(4, solution.MinMovesToSeat(seats: [2,2,6,6], students: [1,3,2,6]));
        }
    }
}