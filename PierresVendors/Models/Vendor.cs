using System.Collections.Generic;

namespace PierresVendors.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public int Id { get; }
    public string Description { get; set; }
    private static List<Vendor> _instances = new List<Vendor> { };

    public Vendor(string name, string description)
    {
      Name = name;
      Description = description;
      _instances.Add(this);
      Id = _instances.Count;
    }

    // public static List<Item> GetAll()
    // {
    //   return _instances;
    // }

    // public static void ClearAll()
    // {
    //   _instances.Clear();
    // }

    //   public static Item Find(int searchId)
    // {
    //   return _instances[searchId-1];
    // }
  }
}
