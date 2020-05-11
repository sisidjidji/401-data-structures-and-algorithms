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
            Node inserNode = new Node(numb);
           

            if (head == null)
            {
                inserNode.Current = head;

            }
            else
            {
                inserNode.Value= numb;
                inserNode.Next =head;
            }
        }

        public Boolean Include(int val)
        {
            Node newNode = new Node(val);

            while ((head != null)&&(newNode.Value!=val))  
            {
                newNode.Next = head;
                
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
            public Node Current { get; set; }
        }

    
}
