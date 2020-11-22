using System.Collections.Generic;

namespace leetCode
{
    public class LevelOrder
    {

         public IList<IList<int>> levelOrder(TreeNode root) {
                   List<IList<int>> list = new List<IList<int>>();
           Queue<TreeNode> queue = new Queue<TreeNode>();
        
        if(root == null) return list;
        
        queue.Enqueue(root);
        while(queue.Count!=0){
            int levelNum = queue.Count;
            List<int> subList = new List<int>();
            for(int i=0; i<levelNum; i++) {
                if(queue.Peek().left != null) queue.Enqueue(queue.Peek().left);
                if(queue.Peek().right != null) queue.Enqueue(queue.Peek().right);
                subList.Add(queue.Dequeue().val);
            }
            list.Add(subList);
        }
    return list;
    }
    }
}