using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pose.IL;
using System;

namespace Pose.Tests
{
  [TestClass]
  public class MethodDisassemblerTests
  {
    [TestMethod]
    public void TestGetILInstructions()
    {
      MethodDisassembler methodDisassembler
          = new MethodDisassembler(typeof(Console).GetMethod("Clear"));
      Assert.AreNotEqual(0, methodDisassembler.GetILInstructions().Count);
    }
  }
}