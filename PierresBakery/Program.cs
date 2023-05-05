using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using PierresBakery.Models;


namespace PierresBakery
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("------------------------------");
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Bread costs $5 each with a deal of buy 2 get 1 free.");
      Console.WriteLine("Pastries cost $2 each with a deal of buy 3 get 1 free.");
      Console.WriteLine("Enter the number of Bread loaves you would like to buy:");
      int breadInput = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter the number of Pastries you would like to buy:");
      int pastryInput = int.Parse(Console.ReadLine());

      Bread newBread = new Bread(breadInput);
      Pastry newPastry = new Pastry(pastryInput);
      int breadCost = newBread.GetBreadCost;
      int pastryCost = newPastry.GetPastryCost;
      int totalCost = newBread.GetOrderTotal(breadCost, pastryCost);

      Console.WriteLine($"The total for your order of {breadInput} bread and {pastryInput} pastries is");
      Console.WriteLine(breadCost);
      Console.WriteLine(totalCost);
    }
  }
}
// namespace WeekdayFinder
// {
//   public class Program
//   {
//     public static void Main()
//     {
//       Console.WriteLine("Enter a year:");
//       int year = int.Parse(Console.ReadLine());
//       Console.WriteLine("Enter a month(number):");
//       int month = int.Parse(Console.ReadLine());
//       Console.WriteLine("Enter a day:");
//       int day = int.Parse(Console.ReadLine());
//       try
//       {
//         DateTime date = new DateTime(year, month, day);
//         Calendar newCalendar = CultureInfo.InvariantCulture.Calendar;
//         Console.WriteLine(newCalendar.GetDayOfWeek(date));
//       }
//       catch(Exception invalidDate)
//       {
//         Console.WriteLine(invalidDate.Message);
//         Console.WriteLine("Please enter a date between 01/01/0001 and 12/31/9999");
//       }
//       Console.WriteLine("Would you like to check another date? (yes/no)");
//       string response = Console.ReadLine();
//       if (response == "yes")
//       {
//         Main();
//       }
//       else
//       {
//         Console.WriteLine("Goodbye");
//       }
//     }
//   }
// }