using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.BinaryTree
{
    public class BinaryTree<T>
    {
        public Node<T> Root;


        public IEnumerable<T> PreOrder(Node<T> Root)
        {
            yield return Root.Value;

            if (Root == null)
            {
                throw new IndexOutOfRangeException();
            }
            if (Root.Left != null)
            {
                foreach (T node in PreOrder(Root.Left))
                {
                    yield return node;
                }


            }
            if (Root.Right != null)
            {
                foreach (T node in PreOrder(Root.Right))
                {
                    yield return node;
                }
            }


        }

        public IEnumerable<T> InOrder(Node<T> Root)
        {


            if (Root == null)
            {
                throw new IndexOutOfRangeException();
            }

            if (Root.Left != null)
            {
                foreach (T node in InOrder(Root.Left))
                {
                    yield return node;
                }
            }

            yield return Root.Value;

            if (Root.Right != null)
            {
                foreach (T node in InOrder(Root.Right))
                {
                    yield return node;
                }
            }


        }

        public IEnumerable<T> PostOrder(Node<T> Root)
        {
            if (Root == null)
            {
                throw new IndexOutOfRangeException();
            }

            if (Root.Left != null)
            {
                foreach (T node in PostOrder(Root.Left))
                {
                    yield return node;
                }
            }


            if (Root.Right != null)
            {
                foreach (T node in PostOrder(Root.Right))
                {
                    yield return node;
                }
            }

            yield return Root.Value;



        }


        public IEnumerable<T> BreadthFirst()
        {
            Queue<Node<T>> breadth = new Queue<Node<T>>();

            breadth.Enqueue(this.Root);

            while (breadth.Count > 0)
            {
                var current = breadth.Dequeue();

                yield return current.Value;



                if (current.Left != null)
                {

                    breadth.Enqueue(current.Left);
                }

                if (current.Right != null)
                {
                    breadth.Enqueue(current.Right);

                }


            }

        }

       
        public int FindMax(Node<int> node)
        {
           if (node == null)
            {
                return 0;
            }

            int tempMaxVal = node.Value;
            int leftMaxVal = FindMax(node.Left);
            int rightMaxVal = FindMax(node.Right);

            if (leftMaxVal > tempMaxVal)
            {
                tempMaxVal = leftMaxVal;
            }

            else if (rightMaxVal > tempMaxVal)
            {
                tempMaxVal = rightMaxVal;
            }

            return tempMaxVal;
        }
    }


    
    public class Node<T>
    {
        public Node( T value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public T Value { get; set; }
        public Node <T> Left { get; set; }
        public Node <T> Right { get; set; }

       
    }
}
