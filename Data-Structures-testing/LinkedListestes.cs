using Data_Structures;
using Xunit;

namespace Data_Structures_testing
{
    public class LinkedListTests
    {
        [Fact]
        public void ToString_empty_list_shows_null()
        {
            // Arrange
            LinkedList ll = new LinkedList();

            // Act
            string result = ll.toString();

            // Assert
            Assert.Equal("NULL", result);
        }

        [Fact]
        public void Can_Insert_into_empty_list()
        {
            // Arrange
            LinkedList ll = new LinkedList();

            // Act
            ll.Insert(5);

            // Assert
            Assert.Equal("{5} -> NULL", ll.toString());
        }

        [Fact]
        public void Can_Insert_into_nonempty_list()
        {
            // Arrange
            LinkedList ll = new LinkedList();
            ll.Insert(10);

            // Act
            ll.Insert(5);

            // Assert
            Assert.Equal("{5} -> {10} -> NULL", ll.toString());
        }

        [Fact]
        public void Can_properly_insert_multiple_nodes()
        {
            // arrange
            LinkedList list = new LinkedList();
            //act
            list.Insert(2);
            list.Insert(1);
            list.Insert(4);
            // assert
            Assert.Equal("{4} -> {1} -> {2} -> NULL", list.toString());
        }

        [Fact]
        public void will_return_true_when_finding_value()
        {
            // arrange
            LinkedList list = new LinkedList();

            //act
            list.Insert(3);
            list.Insert(2);
            list.Insert(4);
            // assert
            Assert.True(list.Include(4));
        }
        [Fact]
        public void will_return_false_when_value_notfound()
        {
            // arrange
            LinkedList list = new LinkedList();

            //act


            list.Insert(5);
            list.Insert(3);
            // assert
            Assert.False(list.Include(2));
        }

        [Fact]
        public void can_append()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(4);
            //act


            list.Append(5);
            // assert
            Assert.Equal("{4} -> {2} -> {1} -> {5} -> NULL", list.toString());
        }

        [Fact]
        public void can_append_multiple()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(4);
            //act


            list.Append(5);
            list.Append(7);
            list.Append(9);

            Assert.Equal("{4} -> {2} -> {1} -> {5} -> {7} -> {9} -> NULL", list.toString());

        }

        [Fact]
        public void can_insert_before_middel()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(4);
            list.Insert(5);
            //act

            list.InsertBefore(2,3);

            Assert.Equal("{5} -> {4} -> {3} -> {2} -> {1} -> NULL", list.toString());

        }

        [Fact]
        public void can_insert_before_first()
        {
            // arrange
            LinkedList list = new LinkedList();
            list.Insert(1);
            list.Insert(2);
            list.Insert(4);
            list.Insert(5);
            //act

            list.InsertBefore(5, 3);

            Assert.Equal("{3} -> {5} -> {4} -> {2} -> {1} -> NULL", list.toString());

        }

    }
    }
