using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Data_Structures.Hashtable
{
   public class Hashtable <T>
    {
        public int GetHash(string key)
        {
            int hash = 0;

                 for (int i= 0; i<key.Length; i++)
            {
                hash += key[i];
            }

            int index = hash * 599;
            return index;
        }



        public class Node
        {
            public string key { get; set; }
            public T Value { get; set; }

            public Node Next { get; set; }

            public Node(T value)
            {
                Next = Next;
                Value = value;
                key = key;
            }
        }

    }

    


}
