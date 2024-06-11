namespace LeetCode_Practice
{
    public class BrowserHistory {
    
        DoubleListNode<string> dummyHead;
        DoubleListNode<string> dummyTail;
        DoubleListNode<string> current;
    
        public BrowserHistory(string homepage) {
            dummyHead = new DoubleListNode<string>(null,null,"");
            dummyTail = new DoubleListNode<string>(null,null,"");
    
            DoubleListNode<string> homePageNode = new DoubleListNode<string>(dummyHead, dummyTail, homepage);
            dummyHead.next = homePageNode;
            dummyTail.prev = homePageNode;
            current = homePageNode;
        }
        
        public void Visit(string url) {
            DoubleListNode<string> visitNode = new DoubleListNode<string>(current, dummyTail, url);
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
            //Assert.Equal(X,solution.Test(x));
        }
    }
}