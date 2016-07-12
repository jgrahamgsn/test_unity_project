using UnityEngine;
using System.Collections;

using NUnit.Framework;

[TestFixture]
public class UnitTests {

	[Test]
	public void Test1() {
		Assert.AreEqual (4, 2 + 2);
	}

	[Test]
	public void Test2() {
		Assert.AreEqual (5, 2 + 2);
	}
}
