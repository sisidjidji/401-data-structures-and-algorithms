using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Data_Structures.Hashtable
{
   public class repeatedWord
    {
        public static string ReapetedWords(String str)
        {
          
            string [] value = str.ToLower().Split(' ');
            Dictionary<string, int> hash = new Dictionary<string, int>() ;

            for (int i=0; i < value.Length; i++)
            {
                if (hash.ContainsKey(value[i]))
                {
                   

                    return value[i];
 
                }

                else
                {
                    hash.Add(value[i],1);


                }

               
               
            }

            return "there is no reapeted value";


        }
    }
}
