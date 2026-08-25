/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        
    // 1. אם הגענו למקום ריק - יוצרים ומחזירים צומת חדש (ולא סתם מספר)
        if (root == null) {
            return new TreeNode(val);
        }

        // 2. אם הערך להכנסה גדול מהשורש הנוכחי -> הולכים ימינה
        // (שים לב: בקוד המקורי שלך זה היה הפוך)
        if (val > root.val) {
            root.right = InsertIntoBST(root.right, val);
        }
        // 3. אחרת (הערך קטן) -> הולכים שמאלה
        else {
            root.left = InsertIntoBST(root.left, val);
        }
        // 4. חשוב מאוד: מחזירים את השורש הנוכחי כדי שהעץ לא "ייעלם" ברקורסיה
        return root;
    }
}