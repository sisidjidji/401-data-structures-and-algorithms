using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures.queue_with_stacks
{
    class queue_with_stacks<T>
    {

        Stack<T> stack1 = new Stack<T>();
        Stack<T> stack2 = new Stack<T>();

        public void EnQueueStackQueue(T value)
        {
           
                stack1.Push(value);

        }


    }
}
