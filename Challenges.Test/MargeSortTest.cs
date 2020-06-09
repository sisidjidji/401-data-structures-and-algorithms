﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Challenges.MergeSort;

namespace Challenges.Test
{
    public class MargeSortTest
    {
        [Theory]
        [InlineData(new[] { 8, 4, 23, 42, 16, 15 }, new[] { 4, 8, 15, 16, 23, 42 })]
        [InlineData(new[] { 20, 18, 12, 8, 5, -2 }, new[] { -2, 5, 8, 12, 18, 20 })]
        [InlineData(new[] { 5, 12, 7, 5, 5, 7 }, new[] { 5, 5, 5, 7, 7, 12 })]
        [InlineData(new[] { 2, 3, 5, 7, 13, 11 }, new[] { 2, 3, 5, 7, 11, 13 })]

        public void Can_Do_MargeSort(int[] input, int[] expected)
        {

            // act
            int[] result = MergeSortArray.MergeSort(input);


            //assert 
            Assert.Equal(expected, result);

        }
    }
}
