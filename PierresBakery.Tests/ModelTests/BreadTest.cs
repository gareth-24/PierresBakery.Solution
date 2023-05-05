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
      Bread newBread = new Bread();
      Assert.AreEqual(typeof(Bread), newBread.GetType());
    }

    [TestMethod]
    public void GetBreadCost_ReturnsCostOfSingleLoaf_BreadCost()  //test for an order of 1 bread loaf
    {
      // Arrange
      Bread newBread = new Bread();
      // Act
      int newBreadCost = newBread.GetBreadCost(1);
      // Assert
      Assert.AreEqual(5, newBreadCost);
    }

    [TestMethod]
    public void GetBreadCost_ReturnsCostOfMultipleLoaves_BreadCost()  //test for an order of 7 loaves
    {
      // Arrange
      Bread newBread = new Bread();
      // Act
      int newBreadCost = newBread.GetBreadCost(7);
      // Assert
      Assert.AreEqual(25, newBreadCost); //buy 7 get 2 free, expected cost of $25
    }
  }
}