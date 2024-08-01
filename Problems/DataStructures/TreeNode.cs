public class TreeNode<T> {
    public T val;
    public TreeNode<T> left;
    public TreeNode<T> right;
    public TreeNode(T? val = default, TreeNode<T> left = null, TreeNode<T> right = null) {
        if (val == null && typeof(T) == typeof(int)) 
        { 
            this.val = (T)Convert.ChangeType(0, typeof(T)); 
        }
        else{
            this.val = val; 
        }
        this.left = left;
        this.right = right;
    }
 }
 