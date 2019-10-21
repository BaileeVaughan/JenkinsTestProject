using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;
using UnityEngine.TestTools;

public class SimpleTests
{
    [Test]
    public void SimpleUnityTesy()
    {
        Assert.IsTrue(false, "FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE ");
    }

    [UnityTest]
    public IEnumerator UnityTest()
    {
        yield return new WaitForFixedUpdate();
        Assert.IsTrue(false, "FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE FAILURE ");
    }
}
