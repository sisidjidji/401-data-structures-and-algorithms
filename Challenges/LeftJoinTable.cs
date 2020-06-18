using System;
using System.Collections.Generic;
using System.Text;

namespace Challenges
{
    public static class LeftJoinTable
    {
        public static List<string[]> Leftjoin(Dictionary<string, string> hash1, Dictionary<string, string> hash2)
        {

            List<string[]> result = new List<string[]>();

            foreach (string key in hash1.Keys)
            {
                result.Add( new string []{ key, hash1[key], null });
            }

            foreach (string key in hash1.Keys)
            {
                if (hash2.ContainsKey(key))
                {
                    foreach(string[] arr in result)
                    {
                       if( arr[0] == key)
                        {
                            arr[2] = hash2[key];
                        }
                        
                    }
                 }
             }
            return result;
            }
            
        }
    }

