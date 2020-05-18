using System;

namespace Data_Structures.stakes
{
    public class Stack<T>

    {
        private Node<T> top;
        public T Push(T value)
        {
            Node<T>  newNode = new Node<T>(value) { Next = top };
            top = newNode;
            
                return top.Value;

        }
        public T Pop()
        {

            return default;
        }

        public T Peek()
        {
            if (top == null)
            {
                throw new InvalidOperationException();
            }
            return default;
        }
        private class Node<T>
        {
            public Node(T value)
            {
                Value = value;
             
            }

            public T Value { get; set; }
            public Node<T> Next { get; set; }

        }

    }
    }


