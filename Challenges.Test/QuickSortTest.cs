using Challenges.QuickSort;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Test
{
    public class QuickSortTest
    {
        [Theory]
        [InlineData(new[] {1,2,3,6,8}, 1, 4,new[] {1,2,3,6,8})]
        //[InlineData(new[] { 20, 18, 12, 8, 5, 2, -1 }, 2, 5,new[] { -1, 2, 5, 8, 12, 18, 20 })]
        [InlineData(new[] { 5, 12, 7, 5, 5, 7 }, 1, 5,new[] { 5, 5, 5, 7, 7, 12 })]
        [InlineData(new[] { 2, 3, 5, 7, 13, 11 }, 1, 5,new[] { 2, 3, 5, 7, 11, 13 })]

        public void Can_Do_QuickSortSort(int[] input, int L , int R ,int[] expected)
        {

            // act
            int[] result = QuickSortArray.QuickSort(input , L, R);


            //assert 
            Assert.Equal(expected, result);

        }
    }
}
