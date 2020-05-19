using System;
using Data_Structures.stacks;
using System.Text;

namespace Data_Structures.queue_with_stacks
{
   public class PseudoQueue<T>
    {

        Stack<T> stack1 = new Stack<T>();
        Stack<T> stack2 = new Stack<T>();

        public void EnQueue(T value)
        {
           
                stack1.Push(value);

        }

        public T DeQueue()
        {


           if (stack1 == null)
            {
              throw new InvalidOperationException();
           }

            while (!stack1.IsEmpty())
            {
                stack2.Push(stack1.Pop());

                return stack2.Pop();
            }

                
                
            

            while (!stack2.IsEmpty())
            {
                stack1.Push(stack1.Pop());
            }

            return default;

        }

        public bool IsEmpty()
        {
            if (stack1.IsEmpty())
            {
                return true;
            }

            else 
                return false;

        }


    }
}
