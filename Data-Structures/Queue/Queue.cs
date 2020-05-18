using System;
using System.Text;

namespace Data_Structures.Queue
{
    public class Queue<T>
    {
       private  Node <T> front ;
       private Node  <T> rear;

        public T EnQueus(T value)
        {
            Node<T> newNode = new Node<T>(value);
            newNode.Next = rear;
            rear = newNode;

            return newNode.Value;
        }

     private class Node<T>
        {
            public Node<T>Front { get; set; }
            public Node<T> Rear { get; set; }
            public T Value { get; set; }
            
            public Node <T>Next { get; set; }            

            public Node(T value)
            {
               Value = value;
                Rear = null;
               Front = null;
           
            }
        }
    }
}
