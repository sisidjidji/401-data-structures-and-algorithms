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
            Hashtable<int> hash = new Hashtable<int>();

            //act
            int result = hash.GetHash("hi");
            //assert

            Assert.Equal(125191, result);
        }

        [Fact]
        public void can_Add_key()
        {
            Hashtable<int> hash = new Hashtable<int>();

            
           hash.Add("hi",125);

           Assert.True(hash.Contain("hi"));

        }

        [Fact]

        public void can_find__key()
        {
            Hashtable<int> hash = new Hashtable<int>();

            hash.Add("hi", 125);

            Assert.Equal(125, hash.Find("hi"));

        }

        [Fact]

        public void can_return_null_if_empty()
        {
            Hashtable<int> hash = new Hashtable<int>();

            hash.Add("hi", 125);
            hash.Add("hello", 152);
            hash.Add("moi", 12);

            Assert.Throws<KeyNotFoundException>(() => hash.Find("h"));
         
        }
    }
}
