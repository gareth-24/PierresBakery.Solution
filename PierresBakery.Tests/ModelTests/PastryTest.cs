using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class PastryTests
  {
    [TestMethod]
    public void PastryConstructor_CreatesInstanceofPastry_Pastry()
    {
      Pastry newPastry = new Pastry();
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryCost_ReturnsCostOfSinglePastry_PastryCost()  //test for an order of 1 pastry
    {
      // Arrange
      Pastry newPastry = new Pastry();
      // Act
      int newPastryCost = newPastry.GetPastryCost(1);
      // Assert
      Assert.AreEqual(2, newPastryCost);
    }

  }
}