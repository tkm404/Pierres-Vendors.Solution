using System;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public int Price {get; set;}
    public string Date {get; set;}
    private static DateTime _timeline {get; set;} = new DateTime() ;
    public Order(string title, string desc, int price)
    {
      Title = title;
      Description = desc;
      Price = price;
      Date = _timeline.ToString();
    }

    public DateTime PurchaseDate(int year, int month, int day)
    {
      _timeline = new DateTime(year, month, day);
      return _timeline;
    }

  }
}