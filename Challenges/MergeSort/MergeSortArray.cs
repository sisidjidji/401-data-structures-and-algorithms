using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Text;

namespace Challenges.MergeSort
{
    public class MergeSortArray
    {
        public static int [] MergeSort(int [] arr)
        {
            int n = arr.Length;

            if (n > 1)
            {
                int mid = n + 1 / 2;
                int[] left = arr[0..mid];
                int[] right = arr[mid..n];


                MergeSort(left);
                MergeSort(right);


                Merge(left, right, arr);
            }

            return arr;
        }

        public static int [] Merge(int[] L ,int[] R, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while (i < L.Length && j < R.Length)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i = i + 1;
                }

                else
                {
                    arr[k] = R[j];
                    j = j + 1;
                    k = k + 1;
                }

            } 

            if (i == L.Length)
            {
                arr[k] = L[i];
                i=i+1;
                k=k+1;
            }
            else if(i == R.Length)
            {
                arr[k] = R[j];
                j=j+1;
                k=k+1;
            }

            return arr;
        }
    }
}
