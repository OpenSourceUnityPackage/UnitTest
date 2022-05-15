using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class RuntimeExampleTests
{
    // A Test behaves as an ordinary method
    [Test]
    public void SimplePasses()
    {
        // Use the Assert class to test conditions
        Assert.AreEqual(2, 2);
    }
    
    [Test]
    public void hasProcessorTest()
    {
        string processorString = "thing(arg1=false)";

        bool trueResult = processorString.Contains("thing");
        bool falseResult = processorString.Contains("owijfoij");

        Assert.IsTrue(trueResult);
        Assert.IsFalse(falseResult);
    }
    
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator WithEnumeratorPasses()
    {
        Assert.AreEqual(2, 2);

        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}