using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trees.BinaryTree;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

            var root = BinaryTree.CreateBinaryTree();            
            //var treeStats = new TreeStats();
            var height = BinaryTree.Height(root);
            Console.WriteLine(height);
            Console.WriteLine(BinaryTree.LeftHeight + BinaryTree.RightHeight + 1);
            Console.ReadKey();
        }
    }
}
