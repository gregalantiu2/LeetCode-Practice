namespace LeetCode_Practice
{
    public class DoubleListNode{
        public DoubleListNode prev;
        public DoubleListNode next;
        public int val;
    
        public DoubleListNode(DoubleListNode prev, DoubleListNode next, int val)
        {
            this.prev = prev;
            this.next = next;
            this.val = val;
        }
    }
    public class MyLinkedList {
        DoubleListNode dummyHead = new DoubleListNode(null, null, 0);
        DoubleListNode dummyTail = new DoubleListNode(null,null,0);

        
        public MyLinkedList() {
            dummyHead.next = dummyTail;
            dummyTail.prev = dummyHead;
        }
        
        public int Get(int index) {
            var current = this.dummyHead.next;

            while(current != null && index > 0)
            {
                current = current.next;
                index--;
            }

            if (current != null && current != this.dummyTail && index == 0)
                return current.val;

            return -1;
        }
        
        public void AddAtHead(int val) {
            var newNode = new DoubleListNode(this.dummyHead,this.dummyHead.next,val);
            this.dummyHead.next.prev = newNode;
            this.dummyHead.next = newNode;
        }
        
        public void AddAtTail(int val) {
            var newNode = new DoubleListNode(this.dummyTail.prev, this.dummyTail, val);
            this.dummyTail.prev.next = newNode;
            this.dummyTail.prev = newNode;
        }
        
        public void AddAtIndex(int index, int val) {
            var current = this.dummyHead.next;

            while(current != null && index > 0)
            {
                current = current.next;
                index--;
            }

            if (current != null && index == 0)
            {
                var newNode = new DoubleListNode(current.prev, current, val);
                current.prev.next = newNode;
                current.prev = newNode;
            }
        }
        
        public void DeleteAtIndex(int index) {
            var current = this.dummyHead.next;

            while(current != null && current != this.dummyTail && index > 0)
            {
                current = current.next;
                index--;
            }

            if (current != null && current != this.dummyTail)
            {
                current.prev.next = current.next;
                current.next.prev = current.prev;
            }
        }
    }
    
    /**
     * Your MyLinkedList object will be instantiated and called as such:
     * MyLinkedList obj = new MyLinkedList();
     * int param_1 = obj.Get(index);
     * obj.AddAtHead(val);
     * obj.AddAtTail(val);
     * obj.AddAtIndex(index,val);
     * obj.DeleteAtIndex(index);
     */
    public class DesignLinkedList
    {
        [Fact]
        public void DesignLinkedList_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(X,solution.Test(x));
        }
    }
}