using System;
using System.Dynamic;
using System.Net.Http.Headers;
using System.Transactions;

namespace Data_Structures
{
    public class Linkeslist
    {

        private Node head;
        
        public void Insert(int numb)
        {
            Node newNode = new Node(numb);
           

            if (head !=null)
            {
                newNode.Value = numb;
                newNode.Next = head;

            }
            else
            {
              
            }
        }

        public bool Include(int val)
        {
            Node newNode = new Node(val);

            while (head != null)
            {
                if (newNode.Value != val)
                {
                    return true;

                }
                else
                {
                    newNode.Next = head;
                }

            }
            return false;
        }

        public string toString ()
        {
            Node newNode = head ;

            string result = "";
            while (head != null)
            {
                 result += $"{{{newNode.Value}}}->";
                newNode.Next = head;

                if(newNode.Next !=null)
                {
                    result += $"{{{ newNode.Value}}}";
                }

            }
            return result;
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
