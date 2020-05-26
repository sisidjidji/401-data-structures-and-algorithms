## Implementation: Trees
###Specifications

Read all of these instructions carefully. Name things exactly as described.
Do all your work in a public repository (matching the example provided by your instructor) called data-structures-and-algorithms, with a well-formatted, detailed top-level README.md
Create a branch in your repository called tree
On your branch, create…
C#: Create a class named Tree.cs
JavaScript: a folder named tree which contains a file called tree.js
Python:a folder named tree which contains a file called tree.py
Java: a package named tree which contains files called Tree.java, BinarySearchTree.java, and Node.java
Include any language-specific configuration files required for this challenge to become an individual component, module, library, etc.
NOTE: You can find an example of this configuration for your course in your class lecture repository.

###Features

Create a Node class that has properties for the value stored in the node, the left child node, and the right child node.
Create a BinaryTree class
Define a method for each of the depth first traversals called preOrder, inOrder, and postOrder which returns an array of the values, ordered appropriately.
Any exceptions or errors that come from your code should be semantic, capturable errors. For example, rather than a default error thrown by your language, your code should raise/throw a custom, semantic error that describes what went wrong in calling the methods you wrote for this lab.

Create a BinarySearchTree class
Define a method named add that accepts a value, and adds a new node with that value in the correct location in the binary search tree.
Define a method named contains that accepts a value, and returns a boolean indicating whether or not the value is in the tree at least once.
Structure and Testing
Utilize the Single-responsibility principle: any methods you write should be clean, reusable, abstract component parts to the whole challenge. You will be given feedback and marked down if you attempt to define a large, complex algorithm in one function definition.

Write tests to prove the following functionality:

Can successfully instantiate an empty tree
Can successfully instantiate a tree with a single root node
Can successfully add a left child and right child to a single root node
Can successfully return a collection from a preorder traversal
Can successfully return a collection from an inorder traversal
Can successfully return a collection from a postorder traversal
Ensure your tests are passing before you submit your solution.


# Challenge17

Write a breadth first traversal method which takes a Binary Tree as its unique input. Without utilizing any of the built-in methods available to your language, traverse the input tree using a Breadth-first approach, and return a list of the values in the tree in the order they were encountered.

## Solution

![code challenge17](/assets/17.png)
