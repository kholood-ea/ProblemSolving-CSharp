using System;
using System.Collections.Generic;

namespace leetCode
{
    public class Max_depth
    {
      public int maxDepth(TreeNode root) {
          if (root==null)
          {
              return 0;
          }
int leftNodeDepth=maxDepth(root.left);
int rightNodeDepth=maxDepth(root.right);

          return Math.Max(leftNodeDepth,rightNodeDepth)+1;
        
    }
    }
}