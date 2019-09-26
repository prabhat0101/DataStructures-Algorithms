using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class Graph
    {
        int VertexCount;
        Dictionary<int, List<int>> Edges;

        public Graph(int count)
        {
            VertexCount = count;
            Edges = new Dictionary<int, List<int>>();
            visited = new bool[count+1];
        }

        public bool[] visited;

        public void AddEdge(int e1, int e2)
        {        
            List<int> values;
            Edges.TryGetValue(e1, out values);
            if (values == null)
            {
                values = new List<int>();
                Edges.Add(e1, values);
            }      
            values.Add(e2);
            //for undirected graph

            Edges.TryGetValue(e2, out values);
            if (values == null)
            {
                values = new List<int>();
                Edges.Add(e2, values);
            }
            values.Add(e1);
        }

        public void DFS(int v)
        {
            visited[v] = true;
            if (!Edges.ContainsKey(v) || Edges[v].Count == 0)
            {
                //Console.WriteLine(v);
                return;
            }

            foreach (var i in Edges[v])
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    DFS(i);
                }                 
            }
            //Console.WriteLine(v);
        }

        public void BFS(int v, Queue<int> queue)
        {
            Console.WriteLine(v);
            visited[v] = true;
            if (Edges.Keys.Any(k => k == v))
            {
                foreach (var i in Edges[v])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        queue.Enqueue(i);
                    }
                }
            }
            if (queue.Count == 0)
            {
                //Console.WriteLine(v);
                return;
            }
            BFS(queue.Dequeue(),queue);   
            //Console.WriteLine(v);
        }
    }
}
