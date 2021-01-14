using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using PerigonGames;

namespace Tests
{
    public class IListExtensionsTests
    {
        #region Array
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
            Assert.True(actualResult);
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
        
        #region List

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
            Assert.True(actualResult);
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
        
        #region ArrayList
        [Test]
        public void TestIsNullOrEmptyIntArrayList()
        {
            // Arrange
            var arrayList = new ArrayList() {1, 2, 3};
            
            // Act
            var actualResult = arrayList.IsNullOrEmpty();
            
            // Assert
            Assert.False(actualResult);
        }

        [Test]
        public void TestIsNullOrEmptyStringArrayList()
        {
            //Arrange
            var arrayList = new ArrayList() {"Hello"};
            
            //Act
            var actualResult = arrayList.IsNullOrEmpty();
            
            // Assert
            Assert.False(actualResult);
        }

        [Test]
        public void TestIsNullOrEmptyDoubleArrayList()
        {
            //Arrange
            Double x = 1;
            var array = new ArrayList() { x };
            
            //Act
            var actualResult = array.IsNullOrEmpty();
            
            //Assert
            Assert.False(actualResult);
        }
        
        [Test]
        public void TestIsNullOrEmptyOnNullStringArrayList()
        {
            //Arrange
            String first = null;
            String second = null;
            var array =  new ArrayList() {first, second};
            
            //Act
            var actualResult = array.IsNullOrEmpty();
            
            //Assert
            Assert.True(actualResult);
        }

        [Test]
        public void TestIsNullOrEmptyWithNullArrayList()
        {   
            // Arrange
            ArrayList array = null;
            
            //Act
            var actualResult = array.IsNullOrEmpty();
            
            //Assert
            Assert.True(actualResult);
        }

        [Test]
        public void TestIsNullOrEmptyWithEmptyArrayList()
        {
            // Arrange
            ArrayList array = new ArrayList();
            
            //Act
            var actualResult = array.IsNullOrEmpty();
            
            //Assert
            Assert.True(actualResult);
        }
        #endregion
    }
}
