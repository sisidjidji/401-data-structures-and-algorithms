using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Test
{
   public class BinarySearchTest
    {

        [Theory]

        [InlineData(new[] {4,8,15,16,23,42}, 2)]
        [InlineData(new[] {4, 8,16, 23, 42,7}, -1)]
        [InlineData(new[] {4, 8, 15},2)]
        public void can_return_index_for_odd_array_(int[] input, int expected)
        {
            //arrange 
            int enteredNumber = 15;

            // act
            int result1 = BinarySearchCodeChallenge.BinarySearch(input, enteredNumber);


            //assert 
            Assert.Equal(expected, result1);

        }

    }
}
