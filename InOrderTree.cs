using System.Collections.Generic;

namespace leetCode
{
    public class InOrderTree
    {
  public static List<int> inOrderTraversal(TreeNode root) {
    List<int> list = new List<int>();

    Stack<TreeNode> stack = new Stack<TreeNode>();
    TreeNode cur = root;

    while(cur!=null || stack.Count!=0){
        while(cur!=null){
            stack.Push(cur);
            cur = cur.left;
        }
        cur = stack.Pop();
        list.Add(cur.val);
        cur = cur.right;
    }

    return list;
}
    }
}