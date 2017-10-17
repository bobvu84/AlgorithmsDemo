using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmDemo.Libs.Helpers
{
    public class BinarySearchTree
    {
        public static bool Contains(Node root, int value)
        {
            if (root == null) return false;

            if (root.Value == value)
            {
                return true;
            }

            if (root.Value > value)
            {
                root = root.Left;
                return Contains(root, value);
            }

            if (root.Value < value)
            {
                root = root.Right;
                return Contains(root, value);
            }
            return false;

        }
    }
}
