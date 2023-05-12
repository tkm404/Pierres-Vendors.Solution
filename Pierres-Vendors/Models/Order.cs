using System;
using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; set; }
    public string Price { get; set; }
    public string Date { get; set; }
    private static DateTime _timeline { get; set; } = new DateTime();
    private static List<Order> _instances = new List<Order> { };
    
    public Order(string title, string desc, int price)
    {
      Title = title;
      Description = desc;
      Price = $"${price}";
      Date = _timeline.ToString();
    }

    public DateTime PurchaseDate(int year, int month, int day)
    {
      _timeline = new DateTime(year, month, day);
      _instances.Add(this);
      return _timeline;
    }

    public static List<Order> Find(string date)
    {
      _instances.Contains(new Order {"","",""} )
    }

  }
}