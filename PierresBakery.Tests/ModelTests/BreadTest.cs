using Microsoft.VisualStudio.TestTools.UnitTesting;
using PierresBakery.Models;
using System.Collections.Generic;
using System;

namespace PierresBakery.Tests
{
  [TestClass]
  public class BreadTests
  {
    [TestMethod]
    public void BreadConstructor_CreatesInstanceOfBread_Bread()
    {
      Bread newBread = new Bread(1);
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadCost_ReturnsCostOfSingleLoaf_BreadCost()  //test for an order of 1 bread loaf
    {
      // Arrange
      Bread newBread = new Bread(1);
      // Act
      int newBreadCost = newBread.GetBreadCost();
      // Assert
      Assert.AreEqual(5, newBreadCost);
    }

    [TestMethod]
    public void GetBreadCost_ReturnsCostOfMultipleLoaves_BreadCost()  //test for an order of 7 loaves
    {
      // Arrange
      Bread newBread = new Bread(7);
      // Act
      int newBreadCost = newBread.GetBreadCost();
      // Assert
      Assert.AreEqual(25, newBreadCost); //buy 7 get 2 free, expected cost of $25
    }

    [TestMethod]
    public void GetBreadNumInput_ReturnsBreadNumInput_Int()
    {
      // Arrange
      int amountOfBread = 7;
      Bread newBread = new Bread(amountOfBread);
      // Act
      int result = newBread.NumOfBread;
      // Assert
      Assert.AreEqual(amountOfBread, result); // test that the auto-implemented property works with get
    }

    [TestMethod]
    public void SetBreadNumInput_SetsValueOfBreadNumInput_Void()
    {
    // Arrange
    Bread newBread = new Bread(7);
    int newNumOfBread = 12;
    // Act
    newBread.NumOfBread = newNumOfBread;
    // Assert
    Assert.AreEqual(newNumOfBread, newBread.NumOfBread);  // test that the set functionality works
    }
  }
}