using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public class LeftJoinTable
    {
        public static list<string[]> leftjoin(dictionary<string, string> hash1, dictionary<string, string> hash2)
        {

            list<string[]> result = new list<string[]>();

            foreach (string key in hash1.keys)
            {
                result.add(new string[] { key, hash1[key], null });
            }

            foreach (string key in hash.keys)
            {
                if (hash1.containskey(key))
                {
                    
                 }
             }
            }
            return result;
        }
    }
}
