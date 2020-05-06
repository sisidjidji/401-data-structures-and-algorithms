using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;


namespace Challenges
{
    public class BinarySearchCodeChallenge
    {
        public static int BinarySearch(int[] array, int num)
        {
            int  maxPosition = array.Length-1;
            int  minPosition = 0;
            int midPosition = (minPosition + maxPosition) + 1 / 2;


            while (minPosition <= maxPosition)
            {
                if (array[midPosition]== num)
                {
                    return midPosition;
                }
                else if (array[minPosition]> num)
                {
                     
                    minPosition = midPosition + 1;
                }
                else
                {
                    maxPosition = midPosition -1;
                }


            }

            return -1;
        }

    }
            
}
    

