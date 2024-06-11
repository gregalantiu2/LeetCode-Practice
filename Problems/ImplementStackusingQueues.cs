namespace LeetCode_Practice
{
    public class ImplementStackusingQueuesSolution {
        Queue<int> queue;
    
        public ImplementStackusingQueuesSolution() {
            queue = new Queue<int>();
        }
        
        public void Push(int x) {
            queue.Enqueue(x);
        }
        
        public int Pop() {
            for(int i = 0; i < queue.Count - 1; i++)
            {   
                queue.Enqueue(queue.Dequeue());
            }
    
            return queue.Dequeue();
        }
        
        public int Top() {
            return new Queue<int>(queue.Reverse()).Peek();
        }
        
        public bool Empty() {
            return queue.Count == 0;
        }
    }
    
    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
    **/

    public class ImplementStackusingQueues
    {
        [Fact]
        public void ImplementStackusingQueues_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}