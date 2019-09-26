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

            //var root = BinaryTree.CreateBinaryTree();            
            //var height = BinaryTree.Height(root);
            //Console.WriteLine(height);
            //Console.WriteLine(BinaryTree.LeftHeight + BinaryTree.RightHeight + 1);

            var v = int.Parse(Console.ReadLine());
            var g = new Graph(v);

            //BFS Traversal                  
            g.AddEdge(1, 2);
            g.AddEdge(1, 10);
            g.AddEdge(2, 3);
            g.AddEdge(3, 4);
            g.AddEdge(3, 5);
            g.AddEdge(4, 24);
            g.AddEdge(5, 9);
            g.AddEdge(5, 6);
            g.AddEdge(6, 8);
            var queue = new Queue<int>();
            g.BFS(1, queue);
            //BFS Traversal End

            //Adding edges statically, in actual problem this has to be read from console.
            //Number of disconnected components

            //g.AddEdge(1, 2);
            //g.AddEdge(3, 2);
            //g.AddEdge(4, 3);
            //g.AddEdge(6, 7);
            //var queue = new Queue<int>();
            //var disconnectedComponentCount = 0;

            //for (int i = 1; i < v + 1; i++)
            //{
            //    if (!g.visited[i])
            //    {
            //        disconnectedComponentCount++;
            //        g.BFS(i, queue);
            //    }
            //}

            //Console.WriteLine(disconnectedComponentCount);

            Console.ReadKey();
        }
    }
}
