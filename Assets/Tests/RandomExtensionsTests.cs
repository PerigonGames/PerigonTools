using System.Collections.Generic;
using NUnit.Framework;
using PerigonGames;
using UnityEngine;
using Random = System.Random;

namespace Tests
{
    public class RandomExtensionsTests
    {
        private Random _random = null;
        [SetUp]
        public void Setup()
        {
            _random = new Random();
        }

        [TearDown]
        public void TearDown()
        {
            _random = null;
        }
        
        [Test]
        public void CoinFlipShouldGetTrueAndFalseAtLeastOnce()
        {
            //Arrange
            List<bool> listOfBooleans = new List<bool>();
            
            //Act
            for (int i = 0; i < 10; i++)
            {
                listOfBooleans.Add(_random.CoinFlip());
            }
            
            //Assert
            Assert.Contains(true, listOfBooleans, "Should have coin flipped and gotten true at least once");
            Assert.Contains(false, listOfBooleans, "Should have coin flipped and gotten false at least once");
        }

        #region GetRandomElementArray
        [Test]
        public void TryGetRandomElementWithArrayOfInt()
        {
            //Arrange
            var array = new[] {1, 2, 3};
            var list = new List<int>();

            //Act
            for (int i = 0; i < 100; i++)
            {
                if (_random.NextTryGetElement(array, out var actualResult))
                {
                    list.Add(actualResult);
                }
                else
                {
                    Assert.Fail();
                }
            }

            //Assert
            foreach (var item in list)
            {
                if (item < 1 || item > 3)
                {
                    Assert.Fail();
                }
            }

            Assert.Pass();
        }

        [Test]
        public void TryGetRandomElementWithArrayOfString()
        {
            //Arrange
            var array = new[] {"Hello", "World", "C#", "Unity"};
            var list = new List<string>();

            //Act
            for (int i = 0; i < 100; i++)
            {
                if (_random.NextTryGetElement(array, out var actualResult))
                {
                    list.Add(actualResult);
                }
                else
                {
                    Assert.Fail();
                }
            }

            //Assert
            foreach (var item in list)
            {
                if (item != "Hello" && item != "World" && item != "C#" && item != "Unity")
                {
                    Assert.Fail();
                }
            }
            
            Assert.IsTrue(list.Contains("C#"));
            Assert.IsTrue(list.Contains("Hello"));
            Assert.IsTrue(list.Contains("World"));
            Assert.IsTrue(list.Contains("Unity"));
            Assert.Pass();
        }
        
        [Test]
        public void TryGetRandomElementWithEmptyArray()
        {
            //Arrange
            var array = new int[] {};
            var actualResult = true;
            var actualInt = 1;

            //Act
            actualResult = _random.NextTryGetElement(array, out actualInt);
            
            //Assert
            Assert.AreEqual(default(int), actualInt, "The int should have changed back to its default value");
            Assert.IsFalse(actualResult, "Empty Array should return False");
        }

        [Test]
        public void TryGetRandomElementWithNullArray()
        {
            //Arrange
            var array = new int[1];
            array = null;
            var actualResult = true;
            var actualInt = 1;

            //Act
            actualResult = _random.NextTryGetElement(array, out actualInt);
            
            //Assert
            Assert.AreEqual(default(int), actualInt, "The int should have changed back to its default value");
            Assert.IsFalse(actualResult, "Null Array should return False");
        }
        
        [Test]
        public void TryGetRandomElementWithArrayOfStringWithSomeNull()
        {
            //Arrange
            var array = new[] {"Hello", null, "C#", null};
            var list = new List<string>();

            //Act
            for (int i = 0; i < 100; i++)
            {
                if (_random.NextTryGetElement(array, out var actualResult))
                {
                    list.Add(actualResult);
                }
                else
                {
                    Assert.Fail();
                }
            }
            
            //Assert
            foreach (var item in list)
            {
                if (item != "Hello" && item != "C#" && item != null)
                {
                    Assert.Fail();
                }
            }

            Assert.IsTrue(list.Contains(null));
            Assert.IsTrue(list.Contains("Hello"));
            Assert.IsTrue(list.Contains("C#"));
        }
        
        [Test]
        public void TryGetRandomElementWithArrayOfStringWithAllNull()
        {
            //Arrange
            string x = null;
            var array = new[] { x, x, x, x };
            var list = new List<string>();

            //Act
            for (int i = 0; i < 100; i++)
            {
                _random.NextTryGetElement(array, out var actualResult);
                list.Add(actualResult);
            }
            
            //Assert
            foreach (var item in list)
            {
                if (item != null)
                {
                    Assert.Fail();
                }
            }

            Assert.IsTrue(list.Contains(null));
        }
        #endregion
        
        #region GetRandomElementList
        #endregion
        
        #region GetRandomElementArrayList
        #endregion
    }
}
