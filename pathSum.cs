using System;
using System.Collections.Generic;

namespace leetCode
{
    public class PathSum
    {
        public static bool pathSum(TreeNode root,int sum){

if (root==null)
{
    return false;
}
if (root.val==sum&&root.right==null&&root.left==null)
{
    return true;
}
return pathSum(root.left,sum-root.val)||pathSum(root.right, sum-root.val);
        }
    }
}