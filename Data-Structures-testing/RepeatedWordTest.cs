using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Data_Structures.Hashtable;
namespace Data_Structures_testing
{
    public class RepeatedWordTest
    {

        [Fact]

        public void return_repeated_word()
        {

            string str = "my name she sihem who is she is  ";

            Assert.Equal("she", repeatedWord.ReapetedWords(str));
        }


    }
}
