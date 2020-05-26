using System;
using System.Collections;
using System.Text;
using Data_Structures.Queue;

namespace AnimalShelter
{
    public class AnimalShelter
    {
        public Animal Front { get; set; }
        public Animal Rear { get; set; }

  
        public AnimalShelter(Animal animal)
        {
            Front = animal;
            Rear = animal;
        }

        public Animal Peek()
        {
            return Front;
        }

        public void Enqueue(Animal animal)
        {
            Rear.Next = animal;
            Rear = animal;
        }

    
        public Animal Dequeue()
        {
            Animal temp = Front;
            Front = Front.Next;
            temp.Next = null;
            return temp;
        }


        public Animal Dequeue(string input)
        {
   
            if (input != "dog" && input != "cat")
                return Dequeue();

        
            Animal temp = Front;

            if (input == "dog")
            {
                if (Front is Dog)
                    return Dequeue();

                while (!(Front is Dog))
                {
                    Enqueue(Dequeue());
                    if (Front == temp)
                        return null;
        
                }
            }

            if (input == "cat")
            {
                if (Front is Cat)
                    return Dequeue();

                while (!(Front is Cat))
                {
                    Enqueue(Dequeue());
                    if (Front == temp)
                        return null;
                  

                }
            }

            Animal result = Dequeue();
            while (Front != temp)
            {
                Enqueue(Dequeue());
            }

            return result;
        }
    }



public abstract class Animal
    {
        public object Value { get; set; }
        public Animal Next { get; set; }
    }
public class Cat : Animal
{
    public Cat(object value)
    {
        Value = value;
    }
}
    public class Dog : Animal
    {
        public Dog(object value)
        {
            Value = value;
        }
    }
}
