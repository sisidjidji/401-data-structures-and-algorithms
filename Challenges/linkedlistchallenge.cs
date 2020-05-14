using Data_Structures;
using System;
using System.Collections.Generic;
using System.Text;
using static Data_Structures.LinkedList;

namespace Challenges
{
   public  class Linkedlistchallenge
    {
       

        public static  LinkedList MergeList( LinkedList list1, LinkedList list2)
        {
            Node current1 = list1.Head;
            Node current2 = list2.Head;

            if (current1 == null)
            {
                return list2;
            }

            else if (current2 == null)
            {
                return list1;
            }


            while(current1 != null )
                {

              Node  curent1next = current1.Next;
              Node  current2next = current2.Next;

                current2.Next = current1.Next;
                current1 = current2.Next;

                current1 = curent1next;
                current2 = current2next;
             
                if (curent1next == null)
                {
                    current1.Next = current2next.Next;
                }

                else if (current2next == null)
                {
                    current2.Next = curent1next.Next;
                }

               

            }
            return list1;
        }

    }
 
}
