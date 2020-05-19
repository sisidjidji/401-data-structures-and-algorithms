using Data_Structures.stacks;
using System;
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

            int result=stack.Push(1);

            //assert
            Assert.Equal(1,result);
        
        

        }
        [Fact]
        public void can_pop_items()
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
            Assert.Equal(1, stack.Pop());


        }

        [Fact]
        public void cant_pop_if_null()
        {
            //arrange
            Stack<int> stack = new Stack<int>();

            //act

     
            //assert
            Assert.Throws<InvalidOperationException>(()=>stack.Pop());


        }

        [Fact]
        public void can_pop_to_empty()
        {
            //arrange
            Stack<int> stack = new Stack<int>();

            //act

            stack.Push(5);
            stack.Push(4);
            stack.Push(3);
            stack.Push(2);
            stack.Push(1);


            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();
            stack.Pop();

            //assert
            Assert.True(stack.IsEmpty());

        }


        [Fact]
        public void can_peek_staks()
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
            Assert.Equal(1,stack.Peek());

        }



        [Fact]

        public void is_empty()
        {
            // arrange
            Stack<int> stack = new Stack<int>();
            //act
            stack.Push(1);
            stack.Pop();
            bool result = stack.IsEmpty();
            //assert
            Assert.True(result);
        }

    }
}