using System;
using System.Collections.Generic;
using System.Text;
using leetCode.DataStruct;

namespace leetCode.Medium
{
    public class _1302DeepestLeavesSum
    {
        public int DeepestLeavesSum(TreeNode root)
        {
            if (root == null) return 0;
            if (root.left == null && root.right == null) return root.val;

            Queue<TreeNode> treeQueue = new Queue<TreeNode>();
            TreeNode temp = root;
            treeQueue.Enqueue(temp);
            int sum = 0;
            while (treeQueue.Count != 0)
            {
                int size = treeQueue.Count;
                sum = 0;
                while (size-- > 0)
                {
                    temp = treeQueue.Dequeue();
                    sum += temp.val;

                    if (temp.left != null) treeQueue.Enqueue(temp.left);
                    if (temp.right != null) treeQueue.Enqueue(temp.right);
                }
            }
            return sum;
        }
    }
}
