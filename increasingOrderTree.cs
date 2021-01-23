using System.Collections.Generic;

namespace leetCode
{
    public class Solution {
    public TreeNode IncreasingBST(TreeNode root) {
        TreeNode result=new TreeNode();
        Stack<TreeNode> stack =new Stack<TreeNode>();
        while (root!=null)
        {
            while (root.left!=null)
            {
                if (root.right!=null)
                {
                    stack.Push(root.right);
                }
            }
            
        }
        return result;
    }
}
    
}