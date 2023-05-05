using System;
using System.Collections;
using System.Collections.Generic;

namespace PierresBakery.Models
{
  public class Bread
  {
    public int NumOfBread {get; set; }
    public Bread(int amountOfBread)
    {
      NumOfBread = amountOfBread;
    }
    public int GetBreadCost() //int numberOfLoaves
    {
      int costOfBreadOrder = 0; // initial cost of the order
      int multiplesOf3 = this.NumOfBread/3;  // determine the number of "free" loaves in order
      int modulo3OfOrder = this.NumOfBread%3;  // remaining loaves will cost a full $5
      costOfBreadOrder = (multiplesOf3*10)+(modulo3OfOrder*5);
      return costOfBreadOrder;
    }
    // public int GetOrderTotal()
    // {
    //   return (Bread.GetBreadCost()+Pastry.GetPastryCost());
    // }
  }


  
}