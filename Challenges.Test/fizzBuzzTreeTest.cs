using Data_Structures.tree;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Challenges.Test
{
    public class fizzBuzzTreeTest
    {
        [Fact]

        public void can_feez_buzz()
        {
            BinaryTree<string> tree = new BinaryTree<string>();

            Node<string> node1 = new Node<string>("5");
            Node<string> node2 = new Node<string>("10");
            Node<string> node3 = new Node<string>("7");
            Node<string> node4 = new Node<string>("15");
            Node<string> node5 = new Node<string>("1");
            // Act 
            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;


            //

            //Assert.Equal(new[] { "Buzz", "Buzz", "7", "FizzBuzz", "1" }, tree.()
        }
    }
}
