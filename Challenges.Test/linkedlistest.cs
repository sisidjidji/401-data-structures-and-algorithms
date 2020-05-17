using Data_Structures;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Test
{
   public  class Tests
    {
        [Fact]

        public void can_marge()
        {
            //arrange
            LinkedList list1 = new LinkedList();
            LinkedList list2 = new LinkedList();
            list1.Insert(1);
            list1.Insert(2);
            list1.Insert(3);

            list2.Insert(4);
            list2.Insert(5);
            list2.Insert(6);

            //act

            LinkedList result = Linkedlistchallenge.MergeList(list1, list2);
            //assert

            Assert.Equal("{3} -> {6} -> {2} -> {5} -> {1} -> {4} ->NULL", result.toString());

       }
    }
}
