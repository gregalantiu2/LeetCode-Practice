namespace LeetCode_Practice
{
    // What data structure?
    // Array or Double Linked List
    // Double Linked List, clearing the history would be O(1)
    
    // public class ListNode{
    //     public ListNode prev {get; set;}
    //     public ListNode next {get; set;}
    //     public string val {get; set;}
    
    //     public ListNode(ListNode prev, ListNode next, string val){
    //         this.prev = prev;
    //         this.next = next;
    //         this.val = val;
    //     }
    // }
    
    public class BrowserHistory {
    
        ListNode dummyHead;
        ListNode dummyTail;
        ListNode current;
    
        public BrowserHistory(string homepage) {
            dummyHead = new ListNode(null,null,"");
            dummyTail = new ListNode(null,null,"");
    
            ListNode homePageNode = new ListNode(dummyHead, dummyTail, homepage);
            dummyHead.next = homePageNode;
            dummyTail.prev = homePageNode;
            current = homePageNode;
        }
        
        public void Visit(string url) {
            ListNode visitNode = new ListNode(current, dummyTail, url);
            dummyTail.prev = visitNode;
            current.next = visitNode;
            current = visitNode;
        }
        
        public string Back(int steps) {
            while(current != null && steps > 0)
            {
                if (current.prev == dummyHead){
                    return current.val;
                }
    
                current = current.prev;
                steps--;
            }
    
            return current.val;
        }
        
        public string Forward(int steps) {
            while(current != null && steps > 0)
            {
                if (current.next == dummyTail){
                    return current.val;
                }
                
                current = current.next;
                steps--;
            }
    
            return current.val;
        }
    }
    
    /**
     * Your BrowserHistory object will be instantiated and called as such:
     * BrowserHistory obj = new BrowserHistory(homepage);
     * obj.Visit(url);
     * string param_2 = obj.Back(steps);
     * string param_3 = obj.Forward(steps);
     */
    public class DesignBrowserHistory
    {
        [Fact]
        public void DesignBrowserHistory_Case1()
        {
            Solution solution = new Solution();
            Assert.Equal(X,solution.Test(x));
        }
    }
}