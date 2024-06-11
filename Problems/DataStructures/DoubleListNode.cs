namespace LeetCode_Practice;
public class DoubleListNode<T> {
    public DoubleListNode<T> prev;
    public DoubleListNode<T> next;
    public T val;
    
    public DoubleListNode(DoubleListNode<T> prev, DoubleListNode<T> next, T val)
    {
        this.prev = prev;
        this.next = next;
        this.val = val;
    }
}
