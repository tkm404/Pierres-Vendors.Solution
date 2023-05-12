namespace PierresVendors.Models
{
  public class Order
  {
    public string Title {get; set;}
    public string Description {get; set;}
    public int Price {get; set;}
    public string Date {get; set;}
    public Order(string title, string desc, int price, string date)
    {
      Title = title;
      Description = desc;
      Price = price;
      Date = date;
    }
  }
}