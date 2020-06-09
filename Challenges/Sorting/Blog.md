## How Insertion Sort Works?

We take an unsorted array for our example.
8,4,23,42,16,15

1. Insertion sort compares the first two elements.

2. It finds that 8 >  then 4 It swaps 8 with 4

3. Insertion sort moves ahead and compares  with 4 and 23 it's already sorted so it moves to the next element .

4. Insertion sort moves ahead and compares  with 23 and 42 it's already sorted so it moves to the next element 

5. Insertion sort moves ahead and compares  with 42 and 16 It swaps 16 with 42. It also checks with all the elements of sorted sub-list. Here we see that the sorted sub-list has  and 23 is greater than 16. swap 16 with 23 , the sorted sub-list remains sorted after swapping.


6. Insertion sort moves ahead and compares  with 42 and 15 . swap 42 with 15 then  we check with the sub-list , swap 23 with 15 then swap 16 with 15 


- this diagram show how the sorting works :

![code diagram](/assets/blog1.png)


## Algorithm 

![code challenge19](/assets/19.png)