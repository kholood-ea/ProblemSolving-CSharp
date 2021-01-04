namespace leetCode
{
    public class TreeMerge
    {
        public TreeNode MergeTrees(TreeNode t1, TreeNode t2)
        {
            //using recursion
            if (t1 == null && t2 == null) return null;

            int val = (t1 == null ? 0 : t1.val) + (t2 == null ? 0 : t2.val);
            TreeNode newNode = new TreeNode(val);

            newNode.left = MergeTrees(t1 == null ? null : t1.left, t2 == null ? null : t2.left);
            newNode.right = MergeTrees(t1 == null ? null : t1.right, t2 == null ? null : t2.right);

            return newNode;
            // TreeNode tree3 = new TreeNode();
            // tree3= treeNodeSum(t1,t2);
            // TreeNode tree3Left = tree3;


            // while (t1 != null || t2 != null)
            // {
            //     while (t1.left != null || t2.left != null)
            //     {
            //        tree3Left.left=treeNodeSum(t1.left,t2.left);

            //     }

            // }

            // return tree3;

        }
        public TreeNode treeNodeSum(TreeNode t1, TreeNode t2)
        {
            TreeNode t3 = new TreeNode();
            if (t1 != null && t2 == null)
            {
                t3.val = t1.val;
            }
            if (t1 == null && t2 != null)
            {
                t3.val = t2.val;
            }
            else
            {
                t3.val = t1.val + t2.val;
            }
            return t3;
        }
    }

}