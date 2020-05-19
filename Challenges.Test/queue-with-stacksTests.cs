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

        [Fact]

        public void can_dequeue_toEmpty_value()
        {
            PseudoQueue<int> queue = new PseudoQueue<int>();
            queue.EnQueue(1);
            queue.EnQueue(5);
            queue.EnQueue(7);
            queue.EnQueue(3);
            queue.EnQueue(2);

            queue.DeQueue();
            queue.DeQueue();
            queue.DeQueue();
            queue.DeQueue();
            queue.DeQueue();


            Assert.True(queue.IsEmpty());

        }

    }
}
