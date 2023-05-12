using System;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public int Price {get; set;}
    public int PurchaseYear {get; set;}
    public int PurchaseMonth {get; set;}
    public int PurchaseDay {get; set;}
    public DateTime Date {get; set;}
    public Order(string title, string desc, int price)
    {
      Title = title;
      Description = desc;
      Price = price;
      Date.ToString();
    }

    public void PurchaseDate(int year, int month, int day)
    {
      PurchaseYear = year;
      PurchaseMonth = month;
      PurchaseDay = day;
      DateTime Date = new DateTime(year, month, day);
    }
  }
}