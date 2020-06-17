using Data_Structures.Binarytree;
using System;
using System.Collections.Generic;
using System.Text;
using Challenges;
using Xunit;

namespace Challenges.Test
{
    public class TreeIntersectionTestes
    {
        [Fact]

        public void can_find_value()
        {

            BinarySearchTree<int> tree1 = new BinarySearchTree<int>();
            BinarySearchTree<int> tree2 = new BinarySearchTree<int>();
            //act
            tree1.AddNodeToTree(5);
            tree1.AddNodeToTree(1);
            tree1.AddNodeToTree(7);
            tree1.AddNodeToTree(8);
            tree1.AddNodeToTree(6);

            tree2.AddNodeToTree(5);
            tree2.AddNodeToTree(3);
            tree2.AddNodeToTree(6);
            tree2.AddNodeToTree(1);
            tree2.AddNodeToTree(7);

          

            
        }
    }
}
