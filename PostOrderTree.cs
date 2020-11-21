using System.Collections.Generic;

namespace leetCode
{
	  public class PostOrderTree
    {
        public static List<int> postOrderTree(TreeNode root) {
       List<int> list = new List<int>();
	Stack<TreeNode> lefts = new Stack<TreeNode>();
	while(root != null) {
		list.Add(root.val);
		if (root.left != null) {
			lefts.Push(root.left);
		}
		root = root.right;
		if (root == null && lefts.Count!=0) {
			root = lefts.Pop();
		}
	}
	list.Reverse();
    return list;
}
	// =========================================================
//     public class PostOrderTree
//     {
//           public static LinkedList<int> postOrderTraversal(TreeNode root) {
// 	LinkedList<int> ans = new LinkedList<int>();
// 	Stack<TreeNode> stack = new Stack<TreeNode>();
// 	if (root == null) return ans;
	
// 	stack.Push(root);
// 	while (stack.Count!=0) {
// 		TreeNode cur = stack.Pop();
// 		ans.AddFirst(cur.val);
// 		if (cur.left != null) {
// 			stack.Push(cur.left);
// 		}
// 		if (cur.right != null) {
// 			stack.Push(cur.right);
// 		} 
// 	}
// 	return ans;
// }
    }
    }
