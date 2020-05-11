using System;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Transactions;

namespace Data_Structures
{
    public class LinkesList
    {

        public Node head;
        
        public void Insert(int numb)
        {
            Node newNode = new Node(numb);

            if (head != null)
            {
                newNode.Value = numb;
                newNode.Next = head;

            }
            

                head=newNode;
               
        }

        public bool Include(int val)
        {
            Node current = new Node(val);

            while (head != null)
            {
                if (current.Value == val)
                {
                    return true;

                }
                else
                {
                    current.Next = head;
                }

            }
            return false;
        }

        public override string ToString ()
        {
            Node newNode = head ;

            string result = "";
            while (head != null)
            {
                result += $"{{{newNode.Value}}}->";
                newNode = newNode.Next;
            }
            return result+"NULL";
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
