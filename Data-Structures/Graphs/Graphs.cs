﻿using System;
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

            public bool AddEdge(T firstNodeValue, T secondNodeValue, int weight = 1, bool oneWay = false)
            {
                
                if (!Nodes.ContainsKey(firstNodeValue) || !Nodes.ContainsKey(secondNodeValue)) return false;
                
                Dictionary<T, int> nodeOne = Nodes[firstNodeValue];
                Dictionary<T, int> nodeTwo = Nodes[secondNodeValue];

                if (nodeOne.ContainsKey(firstNodeValue)) return false;

                if (!oneWay && !firstNodeValue.Equals(secondNodeValue))
                {
                    if (nodeTwo.ContainsKey(firstNodeValue)) return false;
                    nodeTwo.Add(firstNodeValue, weight);
                }


                nodeOne.Add(secondNodeValue, weight);
                return true;
           }
        }
   
