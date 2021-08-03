namespace LinkedListTests
{
    using LinkedList;

    using System;

    using Xunit;

    public class ListNodeTests
    {
        [Fact]
        public void Tostring_EmptyIntNode_DefaultIntValue()
        {
            // Arrange
            ListNode<int> head = new ListNode<int>();
            
            // Act
            string result = head.ToString();

            string expected = default(int).ToString();
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Tostring_SingleNode_ValueCorrect()
        {
            // Arrange
            ListNode<int> head = new ListNode<int>(1, null);

            // Act
            string result = head.ToString();

            string expected = "1";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PrintList_SingleNodesList_CorrectValues()
        {
            // Arrange
            ListNode<int> head = new ListNode<int>(1, null);

            // Act
            string result = head.PrintList();

            // Assert
            string expected = "1";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void PrintList_ThreeNodesList_CorrectValues()
        {
            // Arrange
            ListNode<int> head = new ListNode<int>(1, null);
            ListNode<int> secondNode = new ListNode<int>(2, null);
            ListNode<int> thirdNode = new ListNode<int>(3, null);

            head.next = secondNode;
            secondNode.next = thirdNode;

            // Act
            string result = head.PrintList();

            // Assert
            string expected = "1,2,3";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Add_ThreeNodes_AddToEndOk()
        {
            // Arrange
            ListNode<int> head = new ListNode<int>(1, null);
            head.Add(new ListNode<int>(2, null));
            head.Add(new ListNode<int>(3, null));

            // Act
            string result = head.PrintList();

            // Assert
            string expected = "1,2,3";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Remove_MidNodeFromThreeNodes_TwoNodesOk()
        {
            // Arrange
            ListNode<int> head = new ListNode<int>(1, null);
            ListNode<int> secondNode = new ListNode<int>(2, null);
            ListNode<int> thirdNode = new ListNode<int>(3, null);

            head.Add(secondNode);
            head.Add(thirdNode);

            // Act
            ListNode<int> result = head.Remove(secondNode);

            // Assert
            string expected = "1,3";
            Assert.Equal(expected, result.PrintList());
        }

        [Fact]
        public void Remove__FirstNodeFromThreeNodes_TwoNodesOk()
        {
            // Arrange
            ListNode<int> head = new ListNode<int>(1, null);
            ListNode<int> secondNode = new ListNode<int>(2, null);
            ListNode<int> thirdNode = new ListNode<int>(3, null);

            head.Add(secondNode);
            head.Add(thirdNode);

            // Act
            ListNode<int> result = head.Remove(head);

            // Assert
            string expected = "2,3";
            Assert.Equal(expected, result.PrintList());
        }

        [Fact]
        public void Remove__LastNodeFromThreeNodes_TwoNodesOk()
        {
            // Arrange
            ListNode<int> head = new ListNode<int>(1, null);
            ListNode<int> secondNode = new ListNode<int>(2, null);
            ListNode<int> thirdNode = new ListNode<int>(3, null);

            head.Add(secondNode);
            head.Add(thirdNode);

            // Act
            ListNode<int> result = head.Remove(thirdNode);

            // Assert
            string expected = "1,2";
            Assert.Equal(expected, result.PrintList());
        }

        [Fact]
        public void Remove__NodeFromSingleNodeList_NullList()
        {
            // Arrange
            ListNode<int> head = new ListNode<int>(1, null);

            // Act
            ListNode<int> result = head.Remove(head);

            // Assert
            ListNode<int> expected = null;
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        [InlineData(10)]
        public void Length__NItems_LenghtOk(int itemsToAdd)
        {
            ListNode<int> head = new ListNode<int>(0, null);
            for (int i = 0; i < itemsToAdd; i++)
            {
                ListNode<int> newNode = new ListNode<int>(i, null);
                head.Add(newNode);
            }

            int expectedLength = itemsToAdd + 1;
            Assert.Equal(expectedLength, head.Length);
        }

        [Fact]
        public void Reverse_ThreeNodes_Ok()
        {
            // Arrange
            ListNode<int> head = new ListNode<int>(1, null);
            head.Add(new ListNode<int>(2, null));
            head.Add(new ListNode<int>(3, null));

            // Act
            ListNode<int> reversedList = head.Reverse();
            string result = reversedList.PrintList();

            // Assert
            string expected = "3,2,1";
            Assert.Equal(expected, result);
        }

        [Fact]
        public void Reverse_OneNode_Ok()
        {
            // Arrange
            ListNode<int> head = new ListNode<int>(1, null);

            // Act
            ListNode<int> reversedList = head.Reverse();
            string result = reversedList.PrintList();

            // Assert
            string expected = "1";
            Assert.Equal(expected, result);
        }
    }
}
