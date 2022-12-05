using System;

namespace Dealership.Models
{
    public class Car
  {
        // Public auto-implemented properties
    public string MakeModel { get; set; }
    public int Price { get; set; }
    public int Miles { get; set; }
    public bool AllWheel { get; set; }

    // Constructor
    public Car(string makeModel, int price, int miles, bool allWheel)
    {
        MakeModel = makeModel;
        Price = price;
        Miles = miles;
        AllWheel = allWheel;
    }

    public void SalePrice(int discount)
    {
      int priceSub = Price * (discount/100); 
      Price = Price - priceSub;
      // Price = Price - discount; ---> code for discount without percentage <---
    }

    public void SetPrice(int newPrice)
    {
      Price = newPrice;
    }

    public static string MakeSound(string sound)
    {
      return "Our cars sound like " + sound;
    }
    
    public string GetMakeModel()
    {
      return MakeModel;
    }

     public int GetPrice()
    {
      return Price;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public bool GetAllWheel()
    {
      return AllWheel;
    }

    public bool WorthBuying(int maxPrice)
    {
      return (Price <= maxPrice);
    }
  }
}
  




