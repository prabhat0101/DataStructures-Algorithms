using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees.BinaryTree
{
    public static class BinaryTree
    {

        public static int LeftHeight = 0;
        public static int RightHeight = 0;

        public static Node CreateBinaryTree()
        {
            Node root = new Node(8);
            root.Left = new Node(9);
            root.Right = new Node(6);
            root.Right.Left  = new Node(46);
            root.Right.Right = new Node(64);
            root.Left.Left = new Node(2);
            root.Left.Right = new Node(7);
            root.Left.Right.Right = new Node(1);
            root.Left.Right.Left = new Node(16);
            root.Left.Right.Right.Left = new Node(16);
            root.Left.Right.Right.Left.Left = new Node(27);
            root.Left.Right.Right.Left.Right = new Node(72);
            return root;
        }

        public static int Height(Node root)
        {
            if (root == null)
                return 0;
            var leftHeight = Height(root.Left);
            var rightHeight = Height(root.Right);
            var height = 1 + (leftHeight > rightHeight ? leftHeight : rightHeight);            
            LeftHeight = leftHeight;
            RightHeight = rightHeight;            
            return height;
        }       
        
    }

    public class Node
    {
        public int Data = 0;
        public Node Left = null;
        public Node Right = null;

        public Node(int data)
        {
            Data = data;
        }
    }    

    public class TreeStats
    {
        public int Height = 0;
    }



}
