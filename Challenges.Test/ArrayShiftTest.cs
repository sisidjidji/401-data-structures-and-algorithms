using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Test
{
    public class ArrayShiftTest
    {
        [Theory]
        //[InlineData(new[] { 1, 2, 4 }, new[] {1 ,2 , 3, 4})]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 1, 2, 5, 3, 4 })]
        public void Can_Shift_Array_(int[] input, int[] expected)
        {
            //arrange 


            int enteredNumber = 5;

            // act
            int[] result = ArrayChallenges.insertShiftArray(input,enteredNumber);


            //assert 
            Assert.Equal(expected, result);

        }
    }
}
