using Microsoft.VisualStudio.TestPlatform.TestHost;
using System;
using Xunit;

namespace Challenges.Test
{
    public class ArrayReverseTest

    {
        [Theory]
        [InlineData(new[] { 1, 2, 3 }, new[] { 3, 2, 1 })]
        [InlineData(new[] { 1, 2, 3, 4 }, new[] { 4, 3, 2, 1 })]
        public void Can_Reverse_Array_(int[] input ,int[] expected)
        {
            //arrange 
            //input from theory



            // act
            int[] result = Program.ArrayReverse(input);


            //assert 
            Assert.Equal(expected, result);

        }
    }
}
