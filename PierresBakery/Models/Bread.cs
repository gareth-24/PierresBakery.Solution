using System;
using System.Collections;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int GetBreadCost(int numberOfLoaves)
    {
      int costOfBreadOrder = 0; //initial cost of the order
      costOfBreadOrder = numberOfLoaves*5; //start with each loaf costing 5
      return costOfBreadOrder;
    }
  }
}