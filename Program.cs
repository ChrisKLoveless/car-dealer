using System;
using System.Collections.Generic;
using Dealership.Models;

namespace Dealership
{
  public class Program
  {
    public static void Main()
    {
      Car volkswagen = new Car("1974 Volkswagen Thing", 1100, 368792, false);
      Car yugo = new Car("1980 Yugo Koral", 700, 56000, false);
      Car ford = new Car("1988 Ford Country Squire", 1400, 239001, false);
      Car amc = new Car("1976 AMC Pacer", 400, 198000, false);
      Car subi = new Car("1996 Subaru Legacy", 800, 215000, true);

      List<Car> Cars = new List<Car>() { volkswagen, yugo, ford, amc, subi };

      Console.WriteLine("Enter maximum price: ");
      string stringMaxPrice = Console.ReadLine();
      int maxPrice = int.Parse(stringMaxPrice);
      Console.WriteLine("All Wheel Drive? ['Y' for yes, 'Enter' for no]");
      string awdString = Console.ReadLine();

      List<Car> CarsMatchingSearch = new List<Car>(0);

      yugo.SetPrice(300);
      amc.SalePrice(25);

      foreach (Car automobile in Cars)
      {
        if (automobile.WorthBuying(maxPrice))
        {
          CarsMatchingSearch.Add(automobile);
        }
         if (automobile.GetAllWheel() == false && awdString == "y" || awdString == "Y")
        {
          CarsMatchingSearch.Remove(automobile);
        }
      }

      foreach(Car automobile in CarsMatchingSearch)
      {
        Console.WriteLine("----------------------");
        Console.WriteLine(automobile.GetMakeModel());
        Console.WriteLine(automobile.GetMiles() + " miles");
        Console.WriteLine("All Wheel Drive?:" + " " + automobile.GetAllWheel());
        Console.WriteLine("$" + automobile.GetPrice());
      }
    }
  }

}

