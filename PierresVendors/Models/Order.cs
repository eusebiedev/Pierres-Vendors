using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Information { get; set; }
    public string Date { get; set; }
    public decimal Price { get; set; }
    public int Id { get; }
    private static List<Order> _instances = new List<Order> {};

    public Order(string title, string information, string date, decimal price)
    {
      Title = title;
      Information = information;
      Date = date;
      Price = price;
      Id = _instances.Count;
      _instances.Add(this);
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }

    public static Order Find(int searchId)
    {
      return _instances[searchId];
    }
  }
}