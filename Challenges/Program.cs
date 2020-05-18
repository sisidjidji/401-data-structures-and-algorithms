using System;

namespace Challenges
{
    public class Program
    {


        public static void Main(string[] args)
        {
           

        }
        

        //function that reverse the element of the array
       public static int[] ArrayReverse(int []initialArray)
        {
            int[] newArray = new int[6];
            int[] reverseArray = new int [initialArray.Length] ;

            
                for (int i=0; i<initialArray.Length;i++)
                {
                    reverseArray.SetValue(initialArray[initialArray.Length-1-i],i);
                
                }


            return reverseArray;
        }



        public 
    }
}
