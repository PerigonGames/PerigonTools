using NUnit.Framework;
using PerigonGames;
using UnityEngine;

namespace Tests
{
    public class TransformExtensionsTests
    {
        [Test]
        public static void TestResetPositionOfTransform()
        {
            // Arrange
            var capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            var changedPosition = new Vector3(1, 2, 3);
            capsule.transform.position = changedPosition;
            
            // Act
            capsule.transform.ResetPosition();
            
            // Assert
            Assert.AreEqual(capsule.transform.position, Vector3.zero);
        }

        [Test]
        public static void TestResetLocalPositionOfTransform()
        {
            // Arrange
            var childCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            var parentCube = GameObject.CreatePrimitive(PrimitiveType.Capsule);
            childCube.transform.parent = parentCube.transform;
            var position = new Vector3(-14, -10, 14);
            parentCube.transform.position = position;
            
            //Act
            childCube.transform.ResetLocalPosition();
            
            //Assert
            Assert.AreEqual(parentCube.transform.position, position);
            Assert.AreEqual(childCube.transform.localPosition, Vector3.zero);
        }

        [Test]
        public void TestResetScale()
        {
            // Arrange
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localScale = new Vector3(10, 3, 4);
            
            // Act
            cube.transform.ResetScale();
            
            // Assert
            Assert.AreEqual(cube.transform.localScale, Vector3.one);
        }
        
        [Test]
        public void TestResetRotation()
        {
            // Arrange
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.rotation = Quaternion.Euler(1, 2, 3);
            
            // Act
            cube.transform.ResetRotation();
            
            // Assert
            Assert.AreEqual(cube.transform.rotation, Quaternion.Euler(0, 0, 0));
        }
        
        [Test]
        public void TestResetLocalRotation()
        {
            // Arrange
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localRotation = Quaternion.Euler(10,3,3);
            
            // Act
            cube.transform.ResetLocalRotation();
            
            // Assert
            Assert.AreEqual(cube.transform.localRotation, Quaternion.Euler(Vector3.zero));
        }

        [Test]
        public void TestFullReset()
        {
            // Arrange
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.rotation = Quaternion.Euler(10,3,3);
            cube.transform.position = Vector3.back;
            cube.transform.localScale = Vector3.right;

            // Act
            cube.transform.Reset();
            
            // Assert
            Assert.AreEqual(cube.transform.rotation, Quaternion.Euler(0, 0, 0));
            Assert.AreEqual(cube.transform.position, Vector3.zero);
            Assert.AreEqual(cube.transform.localScale, Vector3.one);
        }
        
        [Test]
        public void TestFullLocalReset()
        {
            // Arrange
            var cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localRotation = Quaternion.Euler(10,3,3);
            cube.transform.localPosition = Vector3.back;
            cube.transform.localScale = Vector3.right;

            // Act
            cube.transform.ResetLocal();
            
            // Assert
            Assert.AreEqual(cube.transform.rotation, Quaternion.Euler(0, 0, 0));
            Assert.AreEqual(cube.transform.position, Vector3.zero);
            Assert.AreEqual(cube.transform.localScale, Vector3.one);
        }
    }
}