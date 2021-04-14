using System;
using Xunit;

namespace UnitTests1
{
    public class UnitTest1
    {
        [Fact]
        public void Add_book_to_library()
        {
            // Arrange
            Bag<string> bag = new Bag<string>();

            // ---= The Exorcist =---
            // Act
            bag.Add("The Exorcist");

            // Assert
            Assert.Equal(new[] { "The Exorcist" }, bag);

            // ---= Pet Semetary =---
            // Act
            bag.Add("Pet Semetary");

            // Assert
            Assert.Equal(new[] { "The Exorcist", "Pet Semetary" }, bag);

            // ---= Fire in the Sky =---
            // Act
            bag.Add("Fire in the Sky");
            // Assert
            Assert.Equal(new[] { "The Exorcist", "Pet Semetary", "Fire in the Sky" }, bag);



        }


        [Fact]
        public void Borrow_existing_title_returns_book_and_removes_it()
        {
            // Arrange


            // Act


            // Assert

        }


        [Fact]
        public void Borrowing_missing_title_returns_null()
        {
            // Arrange


            // Act


            // Assert
        }


        [Fact]
        public void Returned_book_back_in_library()
        {
            // Arrange
            Bag<string> bag = new Bag<string>
            {

            }

            // Act


            // Assert

        }


        [Fact]
        public void Removing_from_bag()
        {
            // Arrange
            Bag<string> bag = new Bag<string>
            {
                "The Exorcist",
                "Pet Semetary",
                "Fire in the Sky",
            };

            // ---= Removing The Exorcist =---
            // Act
            bool result = bag.RemoveAt(0);

            // Assert
            Assert.True(result);
            Assert.Equal(new[] { "Pet Semetary", "Fire in the Sky" }, bag);
            Assert.Equal(2, bag.Count);

            // ---= Removing Pet Semetary =---
            // Act
            bool result1 = bag.RemoveAt(1);

            // Assert
            Assert.True(result1);
            Assert.Equal(new[] { "The Exorcist", "Fire in the Sky" }, bag);
            Assert.Equal(2, bag.Count);

            // ---= Removing Fire in the Sky =---
            // Act
            bool result2 = bag.RemoveAt(2);

            // Assert
            Assert.True(result2);
            Assert.Equal(new[] { "The Exorcist", "Pet Semetary" }, bag);
            Assert.Equal(2, bag.Count);

        } // Closes Removing_from_bag







    } // closes whole public class UnitTest1
} // closes namespace
