using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;

namespace Data_Structures.Hashtable
{
   public class Hashtable <T>
    {
        public Node [] Bucket => new Node [1024];
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

        public void Add(string key , T value)
        {
            Node node = new Node(value);
            node.key = key;
                
           int index =  GetHash(key) % 1024;

        if (Bucket[index] == null)
            {
                
                Bucket[index] = node;
                
            }

        else
            
                Bucket[index].Next = node;

               
            
        }

        public bool Contain (string key )
        {
            int index = GetHash(key) % 1024;

            if (Bucket[index] == null){

                return false;
            }

            else 
                return true;
        }

        public T Find (string key)
        {
            int index = GetHash(key) % 1024;

         
                 if (Bucket[index].key == key)
                {
                    return Bucket[index].Value;
                }
                

          
                throw new KeyNotFoundException();
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
