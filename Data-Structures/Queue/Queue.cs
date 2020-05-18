using System;
using System.Text;

namespace Data_Structures.Queue
{
    public class Queue<T>
    {
       private Node <T> front ;

       

        public T EnQueus(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (front == null)
            {
                 front=newNode;

                return newNode.Value;

            }
            
                front.Next = newNode;
           
                return front.Value;
        }

        public T DeQueus()
        {
            if (front == null)
            {
                throw new InvalidOperationException();
            }
            Node <T> dequeue = front;
            front=front.Next;
            dequeue.Next = null;

            return dequeue.Value;
        }


        public T Peek()
        {
            if (front == null)
            {
                throw new InvalidOperationException();
            }
            

            return front.Value;
        }


        public bool IsEmpty()
        {
            if (front == null)
            {
                return true;
            }
            else
            return false;
        }

        private class Node<T>
        {
            
           
            public T Value { get; set; }
            
            public Node <T>Next { get; set; }            
         
            public Node(T value)
            {
                Value = value;
                Next = null;
                 
            }
        }
    }
}
