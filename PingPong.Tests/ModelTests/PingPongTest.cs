using Microsoft.VisualStudio.TestTools.UnitTesting;
using PingPongGenerator.Models;

namespace PingPongGenerator.Tests
{
  [TestClass]
  public class PingPongGenerator
  {
    [TestMethod]
    public void GetNumber_NumberDivisibleByFifteen_True()
    {
      PingPong testPingPongGenerator = new PingPong();

      Assert.AreEqual("ping", testPingPongGenerator.GetNumber(3));
    }
  }
}
