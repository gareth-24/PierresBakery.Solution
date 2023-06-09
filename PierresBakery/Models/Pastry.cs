using System;
using System.Collections;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Pastry
  {
    public int NumOfPastries {get; set; }
    public Pastry(int amountOfPastries)
    {
      NumOfPastries = amountOfPastries;
    }
    public int GetPastryCost()
    {
      int costOfPastryOrder = 0;  // initial cost of the order
      int multiplesOf4 = this.NumOfPastries/4;  // $6 for 4 pastries
      int modulo4OfOrder = this.NumOfPastries%4;  // $2 for each remaining pastry
      costOfPastryOrder = (multiplesOf4*6)+(modulo4OfOrder*2);
      return costOfPastryOrder;
    }
  }
}