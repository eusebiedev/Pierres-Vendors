using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Order
  {
    private static List<Order> _instances = new List<Order> {};
    public string Title { get; set; }
    public string Information { get; set; }
    public string Date { get; set; }
    public int Price { get; set; }
    public int Id { get; }

    public Order(string title, string information, string date, int price)
    {
      Title = title;
      Information = information;
      Date = date;
      Price = price;
      _instances.Add(this);
      Id = _instances.Count;
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
      return _instances[searchId-1];
    }
  }
}