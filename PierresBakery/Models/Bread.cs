using System;
using System.Collections;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int GetBreadCost(int numberOfLoaves)
    {
      int costOfBreadOrder = 0; // initial cost of the order
      int multiplesOf3 = numberOfLoaves/3;  // determine the number of "free" loaves in order
      int modulo3OfOrder = numberOfLoaves%3;  // remaining loaves will cost a full $5
      costOfBreadOrder = (multiplesOf3*10)+(modulo3OfOrder*5);
      return costOfBreadOrder;
    }
  }
}