﻿using System.Collections;
using NUnit.Framework;
using PerigonGames;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class TransformExtensionsTests
    {
        private GameObject cube = null;
        
        [SetUp]
        public void Setup()
        {
            cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        }

        [TearDown]
        public void TearDown()
        {
            cube = null;
        }
        
        #region ResetPosition
        [UnityTest]
        public IEnumerator ResetPositionGoesBackToVector3Zero()
        {
            //Given
            cube.transform.position = Vector3.one;
            
            //When
            cube.transform.ResetPosition();
            
            //Then
            yield return null;
            Assert.AreEqual(cube.transform.position, Vector3.zero);
        }
        
        [UnityTest]
        public IEnumerator TestTransformChangingPosition()
        {
            cube.transform.position = Vector3.one;
            Assert.AreEqual(cube.transform.position, Vector3.one);
            yield return null;
        }

        [UnityTest]
        public IEnumerator ResetPositionScaleAndRotationDoesntChange()
        {
            //Given
            cube.transform.position = Vector3.one;
            cube.transform.localScale = Vector3.down;
            var rotation = Quaternion.Euler(1, 2, 3);
            cube.transform.rotation = rotation;

            //When
            cube.transform.ResetPosition();

            //Then
            Assert.AreEqual(Vector3.zero, cube.transform.position, "Cube Position Vector3.one");
            Assert.AreEqual(Vector3.down, cube.transform.localScale, "Cube Local Scale Vector3.down");
            Assert.AreEqual(rotation, cube.transform.rotation, "Cube Local Rotation is (1,2,3)");
            yield return null;
        }
        #endregion
        
        #region ResetRotation
        [UnityTest]
        public IEnumerator ResetRotationGoesBackToQuaternionIdentity()
        {
            // Given
            var angle = new Vector3(123.4f, 41.2f, 1);
            cube.transform.rotation = Quaternion.Euler(angle);
            
            //When
            cube.transform.ResetRotation();
            
            //Then
            Assert.AreEqual(cube.transform.rotation, Quaternion.identity);
            yield return null;
        }
        
        [UnityTest]
        public IEnumerator TestTransformRotating()
        {
            var angle = new Vector3(123.4f, 41.2f, 1);
            cube.transform.rotation = Quaternion.Euler(angle);
            Assert.AreEqual(cube.transform.rotation, Quaternion.Euler(angle));
            yield return null;
        }

        [UnityTest]
        public IEnumerator ResetRotationScaleAndPositionDoesntChange()
        {
            // Given
            cube.transform.position = Vector3.one;
            cube.transform.localScale = Vector3.down;
            var rotation = Quaternion.Euler(1, 2, 3);
            cube.transform.rotation = rotation;

            //When 
            cube.transform.ResetPosition();

            //Then
            Assert.AreEqual(Vector3.one, cube.transform.position, "Cube Position Vector3.one");
            Assert.AreEqual(Vector3.down, cube.transform.localScale, "Cube Local Scale Vector3.down");
            Assert.AreEqual(Quaternion.identity, cube.transform.localRotation, "Cube Local Rotation is Vector3 zero");
            yield return null;
        }
        #endregion
        
        #region ResetScale
        [UnityTest]
        public IEnumerator ResetScaleGoesBackToVectorOne()
        {
            // Given
            var angle = new Vector3(123.4f, 41.2f, 1);
            cube.transform.localScale = angle;
            
            //When
            cube.transform.ResetScale();
            
            //Then
            Assert.AreEqual(cube.transform.localScale, Vector3.one);
            yield return null;
        }
        
        [UnityTest]
        public IEnumerator TestTransformScaling()
        {
            var angle = new Vector3(123.4f, 41.2f, 1);
            cube.transform.localScale = angle;
            Assert.AreEqual(cube.transform.rotation, angle);
            yield return null;
        }

        [UnityTest]
        public IEnumerator ResetScaleWhereRotationAndPositionDoesntChange()
        {
            // Given
            cube.transform.position = Vector3.one;
            cube.transform.localScale = Vector3.down;
            var rotation = Quaternion.Euler(1, 2, 3);
            cube.transform.rotation = rotation;

            //When
            cube.transform.ResetScale();

            //Then
            Assert.AreEqual(Vector3.one, cube.transform.position, "Cube Position Vector3.one");
            Assert.AreEqual(Vector3.one, cube.transform.localScale, "Cube Local Scale Vector3.one");
            Assert.AreEqual(Quaternion.Euler(1, 2, 3), cube.transform.localRotation, "Cube Local Rotation stays the same");
            yield return null;
        }
        #endregion
        
        #region ResetTransform
        [UnityTest]
        public IEnumerator ResetTransformTestChangeAllProperties()
        {
            // Given
            cube.transform.position = Vector3.one;
            cube.transform.localScale = Vector3.down;
            var rotation = Quaternion.Euler(1, 2, 3);
            cube.transform.rotation = rotation;

            //When
            cube.transform.ResetTransform();

            //Then
            Assert.AreEqual(Vector3.zero, cube.transform.position, "Cube Position Vector3.zero");
            Assert.AreEqual(Vector3.one, cube.transform.localScale, "Cube Local Scale Vector3.one");
            Assert.AreEqual(Quaternion.identity, cube.transform.localRotation, "Cube Local Rotation is (0, 0, 0)");
            yield return null;
        }
        #endregion
    }
}
