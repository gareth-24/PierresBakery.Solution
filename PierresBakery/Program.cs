using System;
using System.Collections;
using System.Collections.Generic;
using PierresBakery.Models;

namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("----------------------------------------------------------");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("----------------------------------------------------------");
      Console.WriteLine("Bread costs $5 each with a deal of buy 2 get 1 free.");
      Console.WriteLine("Pastries cost $2 each with a deal of buy 3 get 1 free.");
      Console.WriteLine("Enter the number of Bread loaves you would like to buy:");

      try
      {
        int breadInput = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the number of Pastries you would like to buy:");
        int pastryInput = int.Parse(Console.ReadLine());        
        Bread newBread = new Bread(breadInput);
        Pastry newPastry = new Pastry(pastryInput);
        int breadCost = newBread.GetBreadCost();
        int pastryCost = newPastry.GetPastryCost();
        int totalCost = newBread.GetOrderTotal(breadCost, pastryCost);

        Console.WriteLine($"The total for your order of {breadInput} bread and {pastryInput} pastries is:");
        Console.WriteLine($"${totalCost}");
      }
      catch(Exception invalidNumberInput) //WIP: end of program is looping somehow
      {
        Console.WriteLine("!!! Error !!!");
        Console.WriteLine(invalidNumberInput.Message);
        Console.WriteLine("please enter a valid positive number.");
        Main();
      }

      Console.WriteLine("Would you like to reset your cart and make another order? (yes/no)");
      string response = Console.ReadLine().ToLower();
      if (response == "yes")
      {
        Main();
      }
      else
      {
        Console.WriteLine("Goodbye. Enjoy your baked goods!");
        Console.WriteLine("----------------------------------------------------------");
      }
    }
  }
}