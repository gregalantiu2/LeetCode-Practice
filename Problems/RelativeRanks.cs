namespace LeetCode_Practice
{
    public partial class Solution {
        public string[] FindRelativeRanks(int[] score) {
            // Create dictionary and result array
            Dictionary<int, int> scoreToIndex = new Dictionary<int,int>();
            string[] result = new string[score.Length];
    
            //map scores to index
            for (int i = 0; i < score.Length; i++)
            {
                scoreToIndex.Add(score[i], i);
            }
    
            //sort scores in descending order
            Array.Sort(score, (a,b) => b.CompareTo(a));
    
            //iterate through scores
            for(int i = 0; i < score.Length; i++)
            {
                int rank = i + 1;
    
                if (rank == 1)
                {
                    //in the new Array, assign the index of the highest score
                    //the index is in the dict with the key being the score
                    result[scoreToIndex[score[i]]] = "Gold Medal"; 
                }
                else if(rank == 2)
                {   
                    result[scoreToIndex[score[i]]] = "Silver Medal";
                }
                else if (rank == 3)
                {
                    result[scoreToIndex[score[i]]] = "Bronze Medal";
                }
                else{
                    result[scoreToIndex[score[i]]] = rank.ToString();
                }
            }
    
            return result;
        }
    }
    public class RelativeRanks
    {
        [Fact]
        public void RelativeRanks_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(["Gold Medal","Silver Medal","Bronze Medal","4","5"], solution.FindRelativeRanks(score: [5,4,3,2,1]));
        }
        [Fact]
        public void RelativeRanks_Case2()
        {
            Solution solution = new Solution();
            Assert.Equal(["Gold Medal","5","Bronze Medal","Silver Medal","4"], solution.FindRelativeRanks(score: [10,3,8,9,4]));
        }
    }
}