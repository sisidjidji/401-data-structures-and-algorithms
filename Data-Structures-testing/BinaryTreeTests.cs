using Xunit;
using Data_Structures.tree;
using Microsoft.VisualStudio.TestPlatform.Common.DataCollection;

namespace Data_Structures_testing
{
    public class BinaryTreeTests
    {
        [Fact]
        public void can_PreOrder_Tree()
        {
            //Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            Node<int> node1 = new Node<int>(5);
            Node<int> node2 = new Node<int>(10);
            Node<int> node3 = new Node<int>(7);
            Node<int> node4 = new Node<int>(12);
            // Act 
            tree.Root= node1 ;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;

            //Assert
            Assert.Equal(new[] { 5, 10, 12, 7 }, tree.PreOrder(tree.Root));
        }

        [Fact]
        public void can_InOrder_Tree()
        {
            //Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            Node<int> node1 = new Node<int>(5);
            Node<int> node2 = new Node<int>(10);
            Node<int> node3 = new Node<int>(7);
            Node<int> node4 = new Node<int>(12);
            Node<int> node5 = new Node<int>(1);
            // Act 
            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;

            //Assert
            Assert.Equal(new[] { 12, 10, 1,5,7}, tree.InOrder(tree.Root));
        }


        [Fact]
        public void can_PostOrder_Tree()
        {
            //Arrange
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            Node<int> node1 = new Node<int>(5);
            Node<int> node2 = new Node<int>(10);
            Node<int> node3 = new Node<int>(7);
            Node<int> node4 = new Node<int>(12);
            Node<int> node5 = new Node<int>(1);
            // Act 
            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;

            node2.Right = node5;

            //Assert
            Assert.Equal(new[] { 12, 1, 10, 7 ,5 }, tree.PostOrder(tree.Root));
        }

        [Fact]
        public void breadth_first_test()
        {
            BinarySearchTree<int> tree = new BinarySearchTree<int>();
            Node<int> node1 = new Node<int>(5);
            Node<int> node2 = new Node<int>(10);
            Node<int> node3 = new Node<int>(7);
            Node<int> node4 = new Node<int>(12);
            Node<int> node5 = new Node<int>(1);

            tree.Root = node1;
            node1.Left = node2;
            node1.Right = node3;
            node2.Left = node4;
            node2.Right = node5;

            Assert.Equal(new[] {5,10,7,12,1}, tree.BreadthFirst());
        }
    }


}
