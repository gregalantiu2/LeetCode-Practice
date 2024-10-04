namespace LeetCode_Practice
{
    public class SparseVector {
        private readonly int[] vector;
    
        public SparseVector(int[] nums) {
            vector = nums;
        }
        
        // Return the dotProduct of two sparse vectors
        public int DotProduct(SparseVector vec) {
            int result = 0;
            for (int i = 0; i < vec.vector.Length; i++)
            {
                result += vector[i] * vec.vector[i];
            }
    
            return result;
        }
    }
    public class DotProductofTwoSparseVectors
    {

    }
}