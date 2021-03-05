using System.Collections.Generic;

namespace Tracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> {};
    public string Name { get; set; }
    public string Description { get; set; }

    public Vendor(string name, string description)
    {
    Name = name;
    Description = description;
    _instances.Add(this);
    }

    public static List<Vendor> GetAll()
    {
      return _instances;
    }
  }
}