using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Text;

namespace Challenges.BreadthFirstGraphe
{
    public class GrapheBreadthFirst
    {
        public List<Node> BreadthFirst(Node root)
        {
            List<Node> node = new List<Node>();
            Queue<Node> breadth = new Queue<Node>();

            breadth.Enqueue(root);

            while (breadth != null)
            {
                Node front = breadth.Dequeue();
                node.Add(front);

                foreach (Node child in front.Children)
                {
                    if (child.Visited == true)
                    {
                        breadth.Enqueue(child);
                    }
                }

            }
            foreach (Node child in node)
            {
                child.Visited = false;
            }

            return node;

        }

        public class Node
        {
            public int Value { get; set; }
            public List<Node> Children { get; set; }
            public bool Visited { get; set; } = false;

            public Node(int value)
            {
                Value = value;
                Children = new List<Node>();
            }


        }
    }
}
