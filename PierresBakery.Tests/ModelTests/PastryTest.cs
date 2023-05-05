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
      Pastry newPastry = new Pastry(1);
      Assert.AreEqual(typeof(Pastry), newPastry.GetType());
    }

    [TestMethod]
    public void GetPastryCost_ReturnsCostOfSinglePastry_PastryCost()  //test for an order of 1 pastry
    {
      // Arrange
      Pastry newPastry = new Pastry(1);
      // Act
      int newPastryCost = newPastry.GetPastryCost(1);
      // Assert
      Assert.AreEqual(2, newPastryCost);
    }

    [TestMethod]
    public void GetPastryCost_ReturnsCostOfMultiplePastries_PastryCost()  //test for an order of many pastries
    {
      // Arrange
      Pastry newPastry = new Pastry(7);
      // Act
      int newPastryCost = newPastry.GetPastryCost(7);
      // Assert
      Assert.AreEqual(12, newPastryCost); //buying 7, get 1 pastry free
    }

    [TestMethod]
    public void GetNumOfPastries_ReturnsNumOfPastries_Int()
    {
      // Arrange
      int amountOfPastries = 4;
      Pastry newPastry = new Pastry(amountOfPastries);
      // Act
      int result = newPastry.NumOfPastries;
      // Assert
      Assert.AreEqual(amountOfPastries, result); // test that the auto-implemented property works with get
    }

    [TestMethod]
    public void SetNumOfPastries_SetsValueOfNumOfPastries_Void()
    {
    // Arrange
    Pastry newPastry = new Pastry(4);
    int newNumOfPastries = 8;
    // Act
    newPastry.NumOfPastries = newNumOfPastries;
    // Assert
    Assert.AreEqual(newNumOfPastries, newPastry.NumOfPastries);  // test that the set functionality works
    }
  }
}