
using Data_Structures.BinaryTree;
using Data_Structures.Hashtable;
using System;
using System.Collections;
using System.Collections.Generic;

public class TreeIntersection 
    {
      
        public static List<int> Tree_intersection(Data_Structures.tree.BinarySearchTree <int> tree1, Data_Structures.tree.BinarySearchTree<int> tree2)
        {
            Hashtable hash = new Hashtable(20) ;
            List<int>result = new List<int> ();
        
        foreach (int value1 in tree1.BreadthFirst())
        {
            int key1 = value1.GetHashCode();
            hash.Add(key1,null);
        }
        foreach(int value2 in tree2.BreadthFirst())
        {
            int key2 = value2.GetHashCode();
            if (hash.Contains(key2))
            {
                result.Add(key2);
            }
        }
        return result;
        
        }


    }

    


    


}
