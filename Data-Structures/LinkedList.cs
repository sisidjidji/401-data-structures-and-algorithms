using System.Runtime.InteropServices;

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
            Node current = head;
            Node newNode = new Node(newVal);
            Node valNode = new Node(val);

            

            while (current.Next != null )
                {
                if (current == valNode)
                {
                    newNode.Next = current;
                    break;
                }
               
                else if (current.Next == valNode)
                    {
                    
                    newNode.Next =current.Next ;
                    current.Next = newNode;
                    break;
                    }
                else
                {
                    current = current.Next;
                }
                         
                    

                }
            }

        public void InsertAfter(int val, int newVal)
        {
            Node current = head;
            Node newNode = new Node(newVal);
            Node valNode = new Node(val);



            while (current.Next != null)
            {
                if (current == valNode)
                {
                    newNode.Next = current.Next;
                    current.Next = newNode;
                    break;
                }

                else if (current.Next == valNode)
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