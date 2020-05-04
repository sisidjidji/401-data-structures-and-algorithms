using System;

namespace Challenges
{
    class Program
    {
        public static void Main(string[] args)
        {
            ArrayReverse();
            

        }
        
       public static void ArrayReverse()
        {
            int[] newArray = new int[6];
            int[] inputArray = { 1, 2, 3, 5, 6, 9 };

            int j = 0;
                for (int i=inputArray.Length-1; i>=0;i--)
                {
                    newArray[i]= inputArray[j];
                j++;
                }

            
            Console.WriteLine(string.Join(",", newArray));
        }
    }
}
