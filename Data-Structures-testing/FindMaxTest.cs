using Data_Structures.tree;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Data_Structures_testing
{
   public  class FindMaxTest
    {
        [Fact]

        public void can_find_Max_Val_on_empty()
        {
            //arrange
            BinaryTree<int> tree = new BinaryTree<int>();

            
            // assert
            Assert.Equal(0, tree.FindMax(tree.Root));

        }

        [Fact]

        public void can_find_Max_Val_on_single_node()
        {
            //arrange
            BinaryTree<int> tree = new BinaryTree<int>();

            Node<int> node1 = new Node<int>(5);
            //act
            tree.Root = node1;
            // assert
            Assert.Equal(5, tree.FindMax(tree.Root));
          
        }

        [Fact]

        public void can_find_Max_Val_on_tree()
        {
            //arrange
            BinaryTree<int> tree = new BinaryTree<int>();

            Node<int> node1 = new Node<int>(5);
            Node<int> node2 = new Node<int>(10);
            Node<int> node3 = new Node<int>(7);
            Node<int> node4 = new Node<int>(12);

            // Act 

            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;

            Assert.Equal(12, tree.FindMax(tree.Root));

        }
    }
}
