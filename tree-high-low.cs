using System.Collections.Generic;

namespace leetCode
{

    class TreeHighLow
    {
        public static int RangeSumBST(TreeNode root, int low, int high) {
            int sum = 0;
        Stack<TreeNode> rights=new Stack<TreeNode>();
        while (root!=null)
        {
            if (root.val>=low && root.val<=high)
            {
                sum=+root.val;
            }
            if (root.right!=null)
            {rights.Push(root.right);    
            }
           
            root = root.left;
		if (root == null && rights.Count!=0) {
			root = rights.Pop();
		}
            
        }
    
    return sum;
    }
    }
}