using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.Hashtable
{
   public class Hashtable
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


    }


}
