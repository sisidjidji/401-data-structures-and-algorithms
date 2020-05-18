using Data_Structures;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Data_Structures_testing
{
   public class stacktests
    {
        [Fact]
        public void peek_empty_stack_throw()
        {
            //arrange
            Stack<int> stack = new Stack<int>();

            //act
            //assert
            Assert.Throws<InvalidOperationException>(() => stack.Peek());

        }

        [Fact]
        public void can_puch_one_item()
        {
            //arrange
            Stack<int> stack = new Stack<int>();

            //act

              stack.Push(5);
          
            //assert
            Assert.NotNull(stack);


        }
        [Fact]
        public void can_puch_multiple_items()
        {
            //arrange
            Stack<int> stack = new Stack<int>();

            //act

            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);

            //assert
            Assert.Contains(1,stack);
            Assert.Contains(2, stack);
            Assert.Contains(3, stack);
            Assert.Contains(4, stack);
            Assert.Contains(5, stack);
        

        }
    }
}