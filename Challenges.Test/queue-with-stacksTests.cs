using Data_Structures.Queue;
using Data_Structures.queue_with_stacks;
using Data_Structures.stacks;
using System;
using System.Text;
using Xunit;


namespace Data_Structures_testing
{

   public  class queue_with_stacksTests
    {

        [Fact]

        public void can_dequeue()
        {
            PseudoQueue <int> queue = new PseudoQueue<int>();
            queue.EnQueue(5);
            queue.DeQueue();
          

            Assert.True(queue.IsEmpty());

        }


        [Fact]

        public void can_dequeue_value()
        {
            PseudoQueue<int> queue = new PseudoQueue<int>();
            queue.EnQueue(5);
            int result=queue.DeQueue();


            Assert.Equal(5,result);

        }

    }
}
