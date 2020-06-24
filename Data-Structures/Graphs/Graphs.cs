using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures.Graphs
{

    public class Graphs
    {
        public class Graph<T>
        {
            Dictionary<T, Dictionary<T, int>> Nodes;
            public Graph()
            {
                Nodes = new Dictionary<T, Dictionary<T, int>>();
            }

            public bool AddNode(T value)
            {
                if (Nodes.ContainsKey(value)) return false;

                Nodes.Add(value, new Dictionary<T, int>());
                return true;
            }

            public bool AddEdge(T firstNodeValue, T secondNodeValue, int weight = 1, bool oneWay = false)
            {

                if (!Nodes.ContainsKey(firstNodeValue) || !Nodes.ContainsKey(secondNodeValue)) return false;

                Dictionary<T, int> nodeOne = Nodes[firstNodeValue];
                Dictionary<T, int> nodeTwo = Nodes[secondNodeValue];

                if (nodeOne.ContainsKey(firstNodeValue)) return false;

                if (!oneWay && !firstNodeValue.Equals(secondNodeValue))
                {
                    if (nodeTwo.ContainsKey(firstNodeValue)) return false;
                    nodeTwo.Add(firstNodeValue, weight);
                }


                nodeOne.Add(secondNodeValue, weight);
                return true;
            }

            public List<T> GetNodes()
            {
                if (Nodes.Keys.Count < 1) return null;
                return Nodes.Keys.ToList();
            }

            public Dictionary<T, int> GetNeighbors(T value)
            {
                if (!Nodes.ContainsKey(value)) return null;

                return Nodes[value];
            }

            public int Size()
            {
                return Nodes.Keys.Count;
            }



            public List<Node<T>> BreadthFirst(Node <T>root)
            {
                List<Node<T>> node = new List<Node<T>>();
                Queue<Node<T>> breadth = new Queue<Node<T>>();

                breadth.Enqueue(root);

                while (breadth != null)
                {
                    Node<T> front = breadth.Dequeue();
                    node.Add(front);

                    foreach (Node<T> child in front.Children)
                    {
                        if (child.Visited == true)
                        {
                            breadth.Enqueue(child);
                        }
                    }

                }
                foreach (Node <T> child in node)
                {
                    child.Visited = false;
                }

                return node;

            }

            public class Node<T>
            {
                public int Value { get; set; }
                public List<Node<T>> Children { get; set; }
                public bool Visited { get; set; } = false;

                public Node(int value)
                {
                    Value = value;
                    Children = new List<Node<T>>();
                }


            }

        }
    }
}