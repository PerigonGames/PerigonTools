using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using PerigonGames;
using UnityEngine;
using UnityEngine.TestTools;

namespace Tests
{
    public class Vector3ExtensionsTests
    {
        [Test]
        public void ResetToVector3Zero()
        {
            var v = new Vector3(0,2,1);
            v.Reset();
            
            Assert.AreEqual(Vector3.zero, v);
        }
    }
}
