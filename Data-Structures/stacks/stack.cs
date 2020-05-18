using System;
using System.Text;

namespace Data_Structures.stacks
{
    public class Stack<T>

    {
        private Node<T> top;
        public T Push(T value)
        {
            Node<T> newNode = new Node<T>(value);

            newNode.Next = top;
            top = newNode;
            
                return top.Value;

        }
        public T Pop()
        {
            if (top == null)
            {
                throw new InvalidOperationException();
            }

            Node<T> node = top ;

            top = top.Next;

            return  node.Value;
        }

        public T Peek()
        {
            if (top == null)
            {
                throw new InvalidOperationException();
            }
            Node<T> newtop = top;

            return newtop.Value ;
        }

        public bool IsEmpty()
        {

            if (top == null)
            {
                return true;
            }
            else 
                return false;
        }
        private class Node<T>
        {
            public Node(T value)
            {
                Value = value;
             
            }

            public T Value { get; }
            public Node<T> Next { get; set; }

        }

    }
    }


