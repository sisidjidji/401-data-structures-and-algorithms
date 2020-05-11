using System;
using System.Collections.Generic;
using System.Xml;
using Xunit;

namespace Data_Structures_testing
{
    public class UnitTest1
    {
        [Fact]
        public void new_list_is_empty()
        {
            //act
            LinkedList newlist = new LinkedList();
            //assert
            Assert.Equal("", newlist.ToString());
        }

        [Fact]
        public void can_add_to_list()
        {
            //arrange
            LinkedList list = new LinkedList();
            //act
            list.Insert(5);
            //assert
            Assert.Equal("5", list.ToString());
        }
    }

    internal class LinkedList
    {
    }
}
