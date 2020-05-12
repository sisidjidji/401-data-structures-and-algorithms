# 401-data-structures-and-algorithms.
# Reverse an Array


## Challenge1
Write a function called reverseArray which takes an array as an argument. Without utilizing any of the built-in methods available to your language, return an array with elements in reversed order.
## Approach & Efficiency
the main idea is to loop through the input array start from the last element set a counter and fill a new array .

## Solution

![code challenge1](/assets/codechallenge1.jpg)
![code challenge1](/assets/codechallenge1-2.jpg)


## Challenge2
Write a function called insertShiftArray which takes in an array and the value to be added. Without utilizing any of the built-in methods available to your language, return an array with the new value added at the middle index.


## Solution

![code challenge2](/assets/challenge2.png)

## Challenge3
Write a function called BinarySearch which takes in 2 parameters: a sorted array and the search key. Without utilizing any of the built-in methods available to your language, return the index of the array’s element that is equal to the search key, or -1 if the element does not exist.

## Solution

![code challenge3](/assets/challenge3.png)

# Singly Linked List
A Linked List is a sequence of Nodes that are connected/linked to each other. The most defining feature of a Linked List is that each Node references the next Node in the link.

## Challenge
Create a Node class that has properties for the value stored in the Node, and a pointer to the next Node.
Within your LinkedList class, include a head property. Upon instantiation, an empty Linked List should be created.
Define a method called insert which takes any value as an argument and adds a new node with that value to the head of the list with an O(1) Time performance.
Define a method called includes which takes any value as an argument and returns a boolean result depending on whether that value exists as a Node’s value somewhere within the list.
Define a method called toString (or __str__ in Python) which takes in no arguments and returns a string representing all the values in the Linked List, formatted as:
"{ a } -> { b } -> { c } -> NULL"

## Approach & Efficiency
the big O is o(n)

## Challenge6
Write the following methods for the Linked List class:

.append(value) which adds a new node with the given value to the end of the list
.insertBefore(value, newVal) which add a new node with the given newValue immediately before the first value node
.insertAfter(value, newVal) which add a new node with the given newValue immediately after the first value node

## Solution

![code challenge6](/assets/Image from iOS.jpg)

# Challenge7
Write the following methods for the Linked List class:
Write a method for the Linked List class which takes a number, k, as a parameter.Return the node’s value that is k from the end of the linked list. You have access to the Node class and all the properties on the Linked List class as well as the methods created in previous challenges.
## Solution

![code challenge7](/assets/LinkedListKSearch.png)