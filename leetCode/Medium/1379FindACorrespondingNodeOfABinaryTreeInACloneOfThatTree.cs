using System;
using System.Collections.Generic;
using System.Text;
using leetCode.DataStruct;

namespace leetCode.Medium
{
    public class _1379FindACorrespondingNodeOfABinaryTreeInACloneOfThatTree
    {
        public TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            if (original==null || cloned == null || target == null)
                return null;
            if (original == target) return cloned;

            TreeNode result = GetTargetCopy(original.left, cloned.left, target);
            if (result == null)
            {
                result = GetTargetCopy(original.right, cloned.right, target);
                if (result == null)
                {
                    return null;
                }
            }
            return result;
        }
    }
}
