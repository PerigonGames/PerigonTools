using System;
using System.Collections.Generic;
using NUnit.Framework;
using PerigonGames;

namespace Tests
{
    public class IListExtensionsTests
    {
        #region TryGetIndex
        
        [Test]
        public void TestArrayTryGetIndex_ReturnNull()
        {
            // Arrange
            String[] stringArray = new String[1];
            
            // Act
            var actualResult = stringArray.NullableGetElementAt(5);

            // Assert
            Assert.IsNull(actualResult, "Should get a null value");
        }
        
        [Test]
        public void TestArrayTryGetIndex_ReturnElement()
        {
            // Arrange
            var expectedResult = "Hi";
            var index = 0;
            String[] stringArray = new String[1];
            stringArray[index] = expectedResult;
            
            // Act
            var actualResult = stringArray.NullableGetElementAt(index);

            // Assert
            Assert.AreEqual(actualResult, expectedResult, "Value should be taken from array");
        }
        
        [Test]
        public void TestListTryGetIndex_ReturnElement()
        {
            // Arrange
            var expectedResult = "Hi";
            var index = 0;
            List<String> stringList = new List<String>();
            stringList.Add(expectedResult);
            
            // Act
            var actualResult = stringList.NullableGetElementAt(index);

            // Assert
            Assert.AreEqual(actualResult, expectedResult, "Value should be taken from array");
        }
        
        #endregion
        
        #region ArrayNullOrEmpty
        [Test]
        public void TestIsNullOrEmptyIntArray()
        {
            // Arrange
            var array = new[] {1, 2, 3};
            
            // Act
            var actualResult = array.IsNullOrEmpty();
            
            // Assert
            Assert.False(actualResult);
        }

        [Test]
        public void TestIsNullOrEmptyStringArray()
        {
            //Arrange
            var array = new[] {"Hello"};
            
            //Act
            var actualResult = array.IsNullOrEmpty();
            
            // Assert
            Assert.False(actualResult);
        }

        [Test]
        public void TestIsNullOrEmptyDoubleArray()
        {
            //Arrange
            Double x = 1;
            var array = new[] {x};
            
            //Act
            var actualResult = array.IsNullOrEmpty();
            
            //Assert
            Assert.False(actualResult);
        }
        
        [Test]
        public void TestIsNullOrEmptyOnNullStringArray()
        {
            //Arrange
            String first = null;
            String second = null;
            var array = new[] {first, second};
            
            //Act
            var actualResult = array.IsNullOrEmpty();
            
            //Assert
            Assert.False(actualResult);
        }

        [Test]
        public void TestIsNullOrEmptyWithNullArray()
        {   
            // Arrange
            int[] array = null;
            
            //Act
            var actualResult = array.IsNullOrEmpty();
            
            //Assert
            Assert.True(actualResult);
        }

        [Test]
        public void TestIsNullOrEmptyWithEmptyArray()
        {
            // Arrange
            int[] array = new int[] {};
            
            //Act
            var actualResult = array.IsNullOrEmpty();
            
            //Assert
            Assert.True(actualResult);
        }
        #endregion
        
        #region ListNullOrEmpty

        [Test]
        public void TestIsNullOrEmptyIntList()
        {
            // Arrange
            var list = new List<int>() { 1 };
            
            // Act
            var actualResult = list.IsNullOrEmpty();
            
            // Assert
            Assert.False(actualResult);
        }
        
        [Test]
        public void TestIsNullOrEmptyStringList()
        {
            // Arrange
            var list = new List<string>() { "Hello World" };
            
            // Act
            var actualResult = list.IsNullOrEmpty();
            
            // Assert
            Assert.False(actualResult);
        }
        
        [Test]
        public void TestIsNullOrEmptyDoubleList()
        {
            //Arrange
            var list = new List<String>() { "Hello World" };
            
            //Act
            var actualResult = list.IsNullOrEmpty();
            
            //Assert
            Assert.False(actualResult);
        }
        
        [Test]
        public void TestIsNullOrEmptyOnNullStringList()
        {
            //Arrange
            String first = null;
            String second = null;
            var list = new List<String>() {first, second};
            
            //Act
            var actualResult = list.IsNullOrEmpty();
            
            //Assert
            Assert.False(actualResult);
        }
        
        [Test]
        public void TestIsNullOrEmptyOnNullList()
        {
            //Arrange
            List<String> list = null;
            
            //Act
            var actualResult = list.IsNullOrEmpty();
            
            //Assert
            Assert.True(actualResult);
        }
        
        [Test]
        public void TestIsNullOrEmptyOnEmptyList()
        {
            //Arrange
            List<String> list = new List<string>();

            //Act
            var actualResult = list.IsNullOrEmpty();
            
            //Assert
            Assert.True(actualResult);
        }
        #endregion
        
        #region ShuffleArray
        
        [Test]
        public void ShuffleArrayOfInt()
        {
            var array = new[] {1, 2, 3};
            
            array.ShuffleFisherYates();

            Assert.AreEqual(array.Length, 3);
            Assert.Contains(1, array);
            Assert.Contains(2, array);
            Assert.Contains(3, array);
        }
        
        [Test]
        public void ShuffleArrayOfString()
        {
            var array = new[] {"Hello", "There", "String"};
            
            array.ShuffleFisherYates();

            Assert.AreEqual(array.Length, 3);
            Assert.Contains("Hello", array);
            Assert.Contains("There", array);
            Assert.Contains("String", array);
        }
        
        [Test]
        public void ShuffleNullArray()
        {
            var array = new[] {"Hello", "There", "String"};
            array = null;
            
            array.ShuffleFisherYates();

            Assert.IsNull(array);
        }
        
        [Test]
        public void ShuffleArrayOfStringsAndNulls()
        {
            var array = new[] {null, "There", null};

            array.ShuffleFisherYates();

            Assert.AreEqual(array.Length, 3);
            Assert.Contains(null, array);
            Assert.Contains("There", array);
        }
        
        [Test]
        public void ShuffleEmptyArrayOfStrings()
        {
            var array = new string[] { };

            array.ShuffleFisherYates();

            Assert.IsEmpty(array);
        }

        #endregion

        #region ShuffleList
        
        [Test]
        public void ShuffleListOfInt()
        {
            var list = new List<int> {1, 2, 3};
            
            list.ShuffleFisherYates();

            Assert.AreEqual(list.Count, 3);
            Assert.Contains(1, list);
            Assert.Contains(2, list);
            Assert.Contains(3, list);
        }
        
        [Test]
        public void ShuffleListOfString()
        {
            var list = new List<string> {"Hello", "There", "String"};
            
            list.ShuffleFisherYates();

            Assert.AreEqual(list.Count, 3);
            Assert.Contains("Hello", list);
            Assert.Contains("There", list);
            Assert.Contains("String", list);
        }
        
        [Test]
        public void ShuffleNullList()
        {
            var list = new[] {"Hello", "There", "String"};
            list = null;
            
            list.ShuffleFisherYates();

            Assert.IsNull(list);
        }
        
        [Test]
        public void ShuffleListOfStringsAndNulls()
        {
            var list = new List<string> {null, "There", null};

            list.ShuffleFisherYates();

            Assert.AreEqual(list.Count, 3);
            Assert.Contains(null, list);
            Assert.Contains("There", list);
        }
        
        [Test]
        public void ShuffleEmptyListOfStrings()
        {
            var array = new List<string> { };

            array.ShuffleFisherYates();

            Assert.IsEmpty(array);
        }
        
        #endregion
    }
}
