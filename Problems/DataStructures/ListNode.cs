namespace LeetCode_Practice;

public class ListNode<T> {
    public T val;
    public ListNode<T> next;
    public ListNode (T val = default(T), ListNode<T> next = null) {
        if (val == null && typeof(T) == typeof(int)) 
        { 
            this.val = (T)Convert.ChangeType(0, typeof(T)); 
        }
        else{
            this.val = val; 
        }
        
        this.next = next;
    }
}