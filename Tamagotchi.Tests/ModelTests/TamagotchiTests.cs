using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tamagotchi.Models;



namespace Tamagotchi.Test
{
  [TestClass]
  public class TamagotchiTest
  {
    [TestMethod]
    public void Constructor_ShouldCreateInstanceOf_Tamagotchi()
    {

      Tamagotchi tom = new Tamagotchi();
      Assert.AreEqual(typeof(Tamagotchi), tom.GetType());

    }
  }
}