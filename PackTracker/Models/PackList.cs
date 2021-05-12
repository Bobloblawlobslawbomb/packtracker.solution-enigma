using System.Collections.Generic;

namespace PackTracker.Models
{
  public class PackLists
  {

    public Dictionary<string, List<string>> AllLists { get; set; }

    public PackLists()
    {
      AllLists = new Dictionary<string, List<string>>() { };
    }

    public void AddList(string ListName, List<string> PackingList)
    {
      AllLists.Add(ListName, PackingList);
    }

    public static List<PackList> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
  public class PackList
  {
    public string PackName { get; set; }
    private static List<PackList> ListItems = new List<PackList> { };


    public PackList(string packName)
    {
      PackName = packName;
      ListItems = new List<PackList>();
      ListItems.Add(this);
    }

  }
}