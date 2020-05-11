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
    }
}
