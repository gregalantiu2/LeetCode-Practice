namespace LeetCode_Practice
{
    public class MyCircularDeque {
    
        private List<int> deque;
        private int maxSize;
    
        public MyCircularDeque(int k) {
            deque = new List<int>();
            maxSize = k;
        }
        
        public bool InsertFront(int value) {
            if (!IsFull())
            {
                if (IsEmpty())
                {
                    deque.Add(value);
                }
                else{
                    List<int> temp = new List<int>();
                    temp.AddRange(deque);
                    deque.Clear();
                    deque.Add(value);
                    deque.AddRange(temp);
                }
                return true;
            }
    
            return false;
        }
        
        public bool InsertLast(int value) {
            if (!IsFull())
            {
                deque.Add(value);
                return true;
            }
    
            return false;
        }
        
        public bool DeleteFront() {
            if (!IsEmpty())
            {
                deque.RemoveAt(0);
                return true;
            }
            return false;        
        }
        
        public bool DeleteLast() {
            if (!IsEmpty())
            {
                deque.RemoveAt(deque.Count - 1);
                return true;
            }
            return false;
        }
        
        public int GetFront() {
            if (!IsEmpty())
            {
                return deque[0];
            }
    
            return -1;
        }
        
        public int GetRear() {
            if (!IsEmpty())
            {
                return deque[deque.Count - 1];
            }
    
            return -1;
        }
        
        public bool IsEmpty() {
            if (deque.Count == 0)
            {
                return true;
            }
    
            return false;
        }
        
        public bool IsFull() {
            if (deque.Count == maxSize)
            {
                return true;
            }
    
            return false;
        }
    }
    public class DesignCircularDeque
    {
        [Fact]
        public void DesignCircularDeque_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}