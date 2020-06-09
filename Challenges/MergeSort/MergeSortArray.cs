using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace Challenges.MergeSort
{
    public class MergeSortArray
    {
        public static int[] MergeSort(int[] array)
        {
            int[] left;
            int[] right;
            int[] result = new int[array.Length];
            
            if (array.Length <= 1)
                return array;
          
            int midPoint = array.Length / 2;
            left = new int[midPoint];

            
            if (array.Length % 2 == 0)
                right = new int[midPoint];
           
            else
                right = new int[midPoint + 1];
          
            for (int i = 0; i < midPoint; i++)
                left[i] = array[i];
           
            int x = 0;
            
             for (int i = midPoint; i < array.Length; i++)
            {
                right[x] = array[i];
                x++;
            }
            
            left = MergeSort(left);
            
            right = MergeSort(right);
          
            result = Merge(left, right);
            return result;
        }

        
        public static int[] Merge(int[] L, int[] R)
        {
            int resultLength = R.Length + L.Length;
            int[] result = new int[resultLength];
            //
            int i = 0;
            int j = 0;
            int k =0 ;
         
            while (i < L.Length || j < R.Length)
            {
                
                if (i < L.Length && j < R.Length)
                {
                    //If item on left array is less than item on right array, add that item to the result array 
                    if (L[i] <= R[j])
                    {
                        result[k] = L[i];
                        i++;
                        k++;
                    }
                    
                    else
                    {
                        result[k] = R[j];
                        j++;
                        k++;
                    }
                }
                
                else if (i < L.Length)
                {
                    result[k] = L[i];
                    i++;
                    k++;
                }
                
                else if (j < R.Length)
                {
                    result[k] = R[j];
                    j++;
                    k++;
                }
            }
            return result;
        }
    }
}
