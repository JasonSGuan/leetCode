using System;
using System.Collections.Generic;
using System.Text;
using leetCode.DataStruct;

namespace leetCode.Easy
{
    public class _617MergeTwoBinaryTrees
    {
         
        public class Solution
        {
            public static TreeNode MergeTrees(TreeNode t1, TreeNode t2)
            {
                TreeNode tree = new TreeNode();
                if (t1 != null && t2 != null)
                {
                    tree.val = t1.val + t2.val;
                    tree.left = MergeTrees(t1.left, t2.left);
                    tree.right = MergeTrees(t1.right, t2.right);
                }
                else if (t1 != null || t2 != null)
                {
                    tree.val = (t1 == null ? t2.val : t1.val);
                    tree.left = MergeTrees(t1?.left, t2?.left);
                    tree.right = MergeTrees(t1?.right, t2?.right);
                }
                else
                {
                    tree = null;
                }
                return tree;
            }
        }
    }
}
