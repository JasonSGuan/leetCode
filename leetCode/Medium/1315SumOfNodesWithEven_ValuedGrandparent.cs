using System;
using System.Collections.Generic;
using System.Text;
using leetCode.DataStruct;

namespace leetCode.Medium
{
    public class _1315SumOfNodesWithEven_ValuedGrandparent
    {
        public static int SumEvenGrandparent(TreeNode root)
        {
            int sum = 0;
            if (root == null) return 0;
            if (root.left == null && root.right == null) return 0;
            if (root.val % 2 == 0)
            {
                if (root.left != null)
                {
                    if (root.left.left != null)
                    {
                        sum += root.left.left.val;
                    }
                    if (root.left.right != null)
                    {
                        sum += root.left.right.val;
                    }
                }
                if (root.right != null)
                {
                    if (root.right.left != null)
                    {
                        sum += root.right.left.val;
                    }
                    if (root.right.right != null)
                    {
                        sum += root.right.right.val;
                    }
                }
            }
            sum += SumEvenGrandparent(root.left);
            sum += SumEvenGrandparent(root.right);
            return sum;
        }
    }
}
