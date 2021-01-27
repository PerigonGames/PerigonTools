using System.Collections.Generic;
using System.Text;
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

        #region CoinFlip

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

        #endregion

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
                    Assert.Fail("NextTryGetElement should not return false with a non-null, non-empty array");
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
                    Assert.Fail("NextTryGetElement should not return false with a non-null, non-empty array");
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
        }
        
        [Test]
        public void TryGetRandomElementWithEmptyArray()
        {
            //Arrange
            var array = new int[] {};
            var actualResult = true;
            var actualInt = 10;

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
            var array =  new int[] {};
            array = null;
            var actualResult = true;
            var actualInt = 10;

            //Act
            actualResult = _random.NextTryGetElement(array, out actualInt);
            
            //Assert
            Assert.AreEqual(default(int), actualInt, "The int should have changed back to its default value");
            Assert.IsFalse(actualResult, "NextTryGetElement should return False");
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
                    Assert.Fail("NextTryGetElement should not return false with a non-null, non-empty array");
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
                if (_random.NextTryGetElement(array, out var actualResult))
                {
                    list.Add(actualResult);
                }
                else
                {
                    Assert.Fail("NextTryGetElement should not return false with a non-null, non-empty array");
                }
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
        
        public void TryGetRandomElementWithListOfInt()
        {
            //Arrange
            var list = new List<int> {1, 2, 3};
            var outputList = new List<int>();

            //Act
            for (int i = 0; i < 100; i++)
            {
                if (_random.NextTryGetElement(list, out var actualResult))
                {
                    outputList.Add(actualResult);
                }
                else
                {
                    Assert.Fail();
                }
            }

            //Assert
            foreach (var item in outputList)
            {
                if (item < 1 || item > 3)
                {
                    Assert.Fail();
                }
            }

            Assert.Pass();
        }

        [Test]
        public void TryGetRandomElementWithListOfString()
        {
            //Arrange
            var list = new List<string> {"Hello", "World", "C#", "Unity"};
            var outputList = new List<string>();

            //Act
            for (int i = 0; i < 100; i++)
            {
                if (_random.NextTryGetElement(list, out var actualResult))
                {
                    outputList.Add(actualResult);
                }
                else
                {
                    Assert.Fail("NextTryGetElement should not return false with a non-null, non-empty list");
                }
            }

            //Assert
            foreach (var item in outputList)
            {
                if (item != "Hello" && item != "World" && item != "C#" && item != "Unity")
                {
                    Assert.Fail();
                }
            }
            
            Assert.IsTrue(outputList.Contains("C#"));
            Assert.IsTrue(outputList.Contains("Hello"));
            Assert.IsTrue(outputList.Contains("World"));
            Assert.IsTrue(outputList.Contains("Unity"));
        }
        
        [Test]
        public void TryGetRandomElementWithEmptyList()
        {
            //Arrange
            var list = new List<int>();
            var actualResult = true;
            var actualInt = 10;

            //Act
            actualResult = _random.NextTryGetElement(list, out actualInt);
            
            //Assert
            Assert.AreEqual(default(int), actualInt, "The int should have changed back to its default value");
            Assert.IsFalse(actualResult, "Empty Array should return False");
        }

        [Test]
        public void TryGetRandomElementWithNullList()
        {
            //Arrange
            var list = new List<int>();
            list = null;
            var actualResult = true;
            var actualInt = 10;

            //Act
            actualResult = _random.NextTryGetElement(list, out actualInt);
            
            //Assert
            Assert.AreEqual(default(int), actualInt, "The int should have changed back to its default value");
            Assert.IsFalse(actualResult, "NextTryGetElement should return False");
        }
        
        [Test]
        public void TryGetRandomElementWithListOfStringWithSomeNull()
        {
            //Arrange
            var list = new List<string> {"Hello", null, "C#", null};
            var outputList = new List<string>();

            //Act
            for (int i = 0; i < 100; i++)
            {
                if (_random.NextTryGetElement(list, out var actualResult))
                {
                    outputList.Add(actualResult);
                }
                else
                {
                    Assert.Fail("NextTryGetElement should not return false with a non-null, non-empty list");
                }
            }
            
            //Assert
            foreach (var item in outputList)
            {
                if (item != "Hello" && item != "C#" && item != null)
                {
                    Assert.Fail();
                }
            }

            Assert.IsTrue(outputList.Contains(null));
            Assert.IsTrue(outputList.Contains("Hello"));
            Assert.IsTrue(outputList.Contains("C#"));
        }
        
        [Test]
        public void TryGetRandomElementWithListOfStringWithAllNull()
        {
            //Arrange
            string x = null;
            var list = new List<string> { x, x, x, x };
            var outputList = new List<string>();

            //Act
            for (int i = 0; i < 100; i++)
            {
                if (_random.NextTryGetElement(list, out var actualResult))
                {
                    outputList.Add(actualResult);
                }
                else
                {
                    Assert.Fail("NextTryGetElement should not return false with a non-null, non-empty list");
                }
            }

            //Assert
            foreach (var item in outputList)
            {
                if (item != null)
                {
                    Assert.Fail();
                }
            }

            Assert.IsTrue(outputList.Contains(null));
        }
        
        #endregion
    }
}
