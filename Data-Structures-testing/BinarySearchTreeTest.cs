using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

using Data_Structures.BinaryTree;

namespace Data_Structures_testing
{
   public class BinarySearchTreeTest
    {

        [Fact]
        public void can_Add_to_empty()
        {
            //Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();


            //assert
            Assert.Null(tree.Root);
            tree.AddNodeToTree(5);
            Assert.NotNull(tree);
        }
        [Fact]
        public void can_Add_to_Single_root_node()
        {
            //Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
     
            //assert
            tree.AddNodeToTree(5);
            tree.AddNodeToTree(1);
            tree.AddNodeToTree(7);

            Assert.NotNull(tree.Root.Left);
            Assert.NotNull(tree.Root.Right);
        }
        
    }


}
