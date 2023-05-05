using System;
using System.Collections;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int GetPastryCost(int numberOfPastries)
    {
      int costOfPastryOrder = 0;  // initial cost of the order
      costOfPastryOrder = numberOfPastries*2; // $2 per pastry
      return costOfPastryOrder;
    }
  }
}