using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Data_Structures.Graphs
{
  
    public class Graphs
    {
        public class Graph<T>
        {
            Dictionary<T, Dictionary<T, int>> Nodes;
            public Graph()
            {
                Nodes = new Dictionary<T, Dictionary<T, int>>();
            }

            public bool AddNode(T value)
            {
                if (Nodes.ContainsKey(value)) return false;

                Nodes.Add(value, new Dictionary<T, int>());
                return true;
            }

        }
   
