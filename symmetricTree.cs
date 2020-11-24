namespace leetCode
{
    public class SymmetricTree
    {
         public static bool IsSymmetric(TreeNode root) {
             if (root==null)
             {
                 return true;
             }
        
    return isSymmetricHelper(root.left,root.right);
    }

    public static bool isSymmetricHelper(TreeNode left,TreeNode right){

        if(left==null || right==null)
        return left==right;
    if(left.val!=right.val)
        return false;

        else
        {
            return isSymmetricHelper(left.left,right.right)&&
            isSymmetricHelper(left.right,right.left);
        }
    }

    }
}