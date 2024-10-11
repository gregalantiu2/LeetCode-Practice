namespace LeetCode_Practice
{
    public class LRUNode {
        public int key { get; set; }
        public int value { get; set; }
        public LRUNode next { get; set; }
        public LRUNode prev { get; set; }
    
        public LRUNode(int key, int value) {
            this.key = key;
            this.value = value;
        }
    }
    
    public class LRUCache {
        private int capacity;
        private Dictionary<int, LRUNode> dic;
        private LRUNode head;
        private LRUNode tail;
    
        public LRUCache(int capacity) {
            this.capacity = capacity;
            dic = new Dictionary<int, LRUNode>();
            head = new LRUNode(-1, -1);
            tail = new LRUNode(-1, -1);
            head.next = tail;
            tail.prev = head;
        }
    
        public int Get(int key) {
            if (!dic.ContainsKey(key)) {
                return -1;
            }
    
            LRUNode LRUNode = dic[key];
            Remove(LRUNode);
            Add(LRUNode);
            return LRUNode.value;
        }
    
        public void Put(int key, int value) {
            if (dic.ContainsKey(key)) {
                LRUNode oldLRUNode = dic[key];
                Remove(oldLRUNode);
            }
    
            LRUNode LRUNode = new LRUNode(key, value);
            dic[key] = LRUNode;
            Add(LRUNode);
            if (dic.Count > capacity) {
                LRUNode LRUNodeToDelete = head.next;
                Remove(LRUNodeToDelete);
                dic.Remove(LRUNodeToDelete.key);
            }
        }
    
        private void Add(LRUNode LRUNode) {
            LRUNode previousEnd = tail.prev;
            previousEnd.next = LRUNode;
            LRUNode.prev = previousEnd;
            LRUNode.next = tail;
            tail.prev = LRUNode;
        }
    
        private void Remove(LRUNode LRUNode) {
            LRUNode.prev.next = LRUNode.next;
            LRUNode.next.prev = LRUNode.prev;
        }
    }
    public class LRUCache_Test
    {
        [Fact]
        public void LRUCache_Case1()
        {
            Solution solution = new Solution();
            //Assert.Equal(X,solution.Test(x));
        }
    }
}