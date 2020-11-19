using System.Collections.Generic;

namespace leetCode
{
    public class PreOrderTree
    {
          public static List<int> PreorderTraversal(TreeNode root) {
       List<int> list = new List<int>();
	Stack<TreeNode> rights = new Stack<TreeNode>();
	while(root != null) {
		list.Add(root.val);
		if (root.right != null) {
			rights.Push(root.right);
		}
		root = root.left;
		if (root == null && rights.Count!=0) {
			root = rights.Pop();
		}
	}
    return list;
    }
    }
}