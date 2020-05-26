using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.tree
{
     public class BinaryTree<T>
    {
        public Node<T> Root ;
     

        public IEnumerable<T> PreOrder(Node <T>Root)
        {
            yield return Root.Value;

           if (Root == null)
            {
                throw new IndexOutOfRangeException();
            }
           if(Root.Left!=null)
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

        public IEnumerable<T> PostOrder (Node<T> Root)
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
