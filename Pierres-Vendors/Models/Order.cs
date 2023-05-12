using System;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public int Price {get; set;}
    public DateTime Date {get; set;}
    public Order(string title, string desc, int price)
    {
      Title = title;
      Description = desc;
      Price = price;
    }
    
  }
}