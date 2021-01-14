using System.Collections;
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
            
        }
        
        #region ResetPosition
        [UnityTest]
        public IEnumerator ResetPositionGoesBackToVector3Zero()
        {
            cube.transform.position = Vector3.one;
            cube.transform.ResetPosition();
            
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
        public IEnumerator ResetPositionScaleDoesntChange()
        {
            cube.transform.position = Vector3.one;
            cube.transform.localScale = Vector3.down;
            cube.transform.localRotation = Quaternion.Euler(1, 2, 3);

            cube.transform.ResetPosition();

            Assert.AreEqual(cube.transform.position, Vector3.one, "This should be at Vector3 one");
            Assert.AreEqual(cube.transform.localScale, Vector3.down);
            Assert.AreEqual(cube.transform.localRotation, Quaternion.Euler(1, 2, 3));
            yield return null;
        }

        #endregion
    }
}
