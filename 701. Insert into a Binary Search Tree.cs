701. Insert into a Binary Search Tree.cs

You are given the root node of a binary search tree (BST) and a value to insert into the tree. Return the root node of the BST after the insertion. It is guaranteed that the new value does not exist in the original BST.

Notice that there may exist multiple valid ways for the insertion, as long as the tree remains a BST after insertion. You can return any of them.

/*----------------------------------------------------------*/

public class Solution {
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        if(root == null) return new TreeNode(val);
        if(val > root.val)
            root.right = InsertIntoBST(root.right, val);
        else
            root.left = InsertIntoBST(root.left, val);
        return root;
    }
}