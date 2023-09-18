using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Pose.Tests
{
  [TestClass]
  public class DictionaryExtensionsTests
  {
    [TestMethod]
    public void TestTryAdd()
    {
      Dictionary<int, string> dictionary = new Dictionary<int, string>();
      Assert.AreEqual<bool>(true, dictionary.TryAdd(0, "0"));
      Assert.AreEqual<bool>(false, dictionary.TryAdd(0, "1"));
    }
  }
}
