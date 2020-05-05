namespace Challenges
{
   public class ArrayChallenges
    {

        //function that reverse the element of the array
        public static int[] insertShiftArray(int[] array, int num)
        {
            int[] newArray = new int[array.Length + 1];
            int middlePosition = array.Length / 2;

            for (int i = 0; i < newArray.Length; i++)
            {
                if (middlePosition > i)
                {
                    newArray[i] = array[i];

                }
                else if (middlePosition == i)
                {
                    newArray[i] = num;
                }
                else  
                {
                    newArray[i] = array[i - 1];

                }
                
            }
            return newArray;
        }
    }

}
