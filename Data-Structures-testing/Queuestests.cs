using System;
using System.Text;
using Xunit;
using Data_Structures.Queue;

namespace Data_Structures_testing
{
   public  class Queuestests
    {
        [Fact]
        public void enqueus_one_value()
        {
            //Arrange
            Queue<int> queue = new Queue<int>();
            //Act
         
           int result= queue.EnQueus(2);
            //Assert
            Assert.Equal(2,result);


         }

        [Fact]
        public void enqueus_multiple_values()
        {
            //Arrange
            Queue<int> queue = new Queue<int>();
            //Act
            queue.EnQueus(4);
            queue.EnQueus(5);
            queue.EnQueus(1);
            queue.EnQueus(7);
            int result = queue.EnQueus(2);
            //Assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void Dequeus_one_values()
        {
            //Arrange
            Queue<int> queue = new Queue<int>();
            //Act
            queue.EnQueus(2);
            queue.EnQueus(5);
            queue.EnQueus(1);
            queue.EnQueus(7);
            int result = queue.DeQueus();
            //Assert
            Assert.Equal(2, result);
        }
        [Fact]
        public void peek_queue()
        {
            //Arrange
            Queue<int> queue = new Queue<int>();
            //Act
            queue.EnQueus(8);
            queue.EnQueus(3);
            queue.EnQueus(5);
            queue.EnQueus(1);
            queue.EnQueus(7);
            int result = queue.Peek();
            //Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void Dequeus_to_empty()
        {
            //Arrange
            Queue<int> queue = new Queue<int>();
            //Act
            queue.EnQueus(2);
            queue.EnQueus(5);
            queue.EnQueus(1);
            queue.EnQueus(7);

            queue.DeQueus();
            queue.DeQueus();
            queue.DeQueus();
            queue.DeQueus();
           

            //Assert
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void queue_is_empty()
        {
            //Arrange
            Queue<int> queue = new Queue<int>();
            //Act
         
            //Assert
            Assert.True(queue.IsEmpty());
        }

        [Fact]
        public void cant_peek_if_null()
        {
            //arrange
            Queue<int> stack = new Queue<int>();

            //act
            

            //assert
            Assert.Throws<InvalidOperationException>(() => stack.Peek());


        }
        [Fact]
        public void cant_dequeue_if_null()
        {
            //arrange
            Queue<int> stack = new Queue<int>();

            //act


            //assert
            Assert.Throws<InvalidOperationException>(() => stack.DeQueus());


        }
    }
}
