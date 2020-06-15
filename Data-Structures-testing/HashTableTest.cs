using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Data_Structures.Hashtable;

namespace Data_Structures_testing
{
   public class HashTableTest
    {
        [Fact]
        public void Can_Hash()
        {
            //Arrange
            Hashtable hash = new Hashtable();

            //act
            int result = hash.GetHash("hi");
            //assert

            Assert.Equal(125191, result);
        }

    }
}
