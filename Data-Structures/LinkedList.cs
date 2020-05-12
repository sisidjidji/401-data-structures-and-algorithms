using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Threading;

namespace Data_Structures
{
    public class LinkedList
    {

        private Node head;

        public void Insert(int numb)
        {
            Node newNode = new Node(numb);

            // Point newNode to rest of the old list
            if (head != null)
            {
                newNode.Next = head;
            }

            head = newNode;
        }

        public bool Include(int val)
        {
            Node current = head;

            while (current.Next != null)
            {
                if (current.Value == val)
                {
                    return true;

                }
                else
                {
                    current = current.Next;
                }

            }
            return false;
        }

        public string toString()
        {
            Node current = head;

            string result = "";
            while (current != null)
            {
                result += $"{{{current.Value}}} -> ";

                // Traverse
                current = current.Next;
            }

            return result + "NULL";
        }

        public void Append(int value)
        {
            Node newNode = new Node(value);

            if (head == null)
            {
                head = newNode;
            }
           
            else
            {
                newNode.Next = null;

                Node current = head;

                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;

            }

        }
        public void InsertBefore(int val, int newVal)
        {

            Node newNode = new Node(newVal);


            if (head == null)
            {
                throw new ArgumentException(" Value not found");
            }

            else if (head.Value == val)
            {

                newNode.Next = head;
                head = newNode;

            }


            else
            {
                Node current = head;

                while (current.Next != null)
                {

                    if (current.Next.Value == val)
                    {

                        newNode.Next = current.Next;
                        current.Next = newNode;
                        return;
                    }
                    else
                    {
                        current = current.Next;
                    }
                }

            }
        }

        public int KthFromEnd(int k)
        {

            int length = 0;
            if (k < 0)
            {
                throw new IndexOutOfRangeException(" error");
            }

            if (head == null)
            {
                throw new ArgumentException(" Value not found");
            }
            Node current = head;
            while (current != null)
            {
                current = current.Next;
                length++;
            }

            int position = length -k-1;

            if (length < k)
            {
                throw new IndexOutOfRangeException("error");

            }
            else if (length == k)
            {
                return head.Value;
            }


            current = head;
           int count = 0;

            while (current!= null && count<position)
            {

                    current = current.Next;

                count++;
  
            }
            return current.Value;
        }
           
        
            

        public void InsertAfter(int val, int newVal)
        {
           
            Node newNode = new Node(newVal);
         
            if (head == null)
            {
                throw new ArgumentException(" Value not found");
            }

           else if (head.Value == val)
            {
                newNode.Next = head.Next;
                head.Next = newNode;
                
            }

            else {

                Node current = head;

                while (current.Next != null)
                {

                if (current.Next.Value ==val )
                    {
                      
                        newNode.Next = current.Next.Next;
                        current.Next.Next = newNode;
                        break;
                    }
                    else
                    {
                        current = current.Next;
                    }

                }

            }
        }

        public class Node
        {
            public Node(int value)
            {
                Value = value;
                Next = null;


            }

            public int Value { get; set; }
            public Node Next { get; set; }

        }

    }
}