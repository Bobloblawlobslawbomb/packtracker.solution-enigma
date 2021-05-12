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

    // public void AddList(string ListName, List<string> PackingList)
    // {
    //   AllLists.Add(ListName, PackingList);
    // }

    // private static List<>

    public void AddList(object NewPackList)
    {
      AllLists.Add(NewPackList.PackName, NewPackList.ListItems);
      PackList.ClearAll();
    }

    public static List<PackList> GetAll()
    {
      return AllLists;
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
    public static void ClearAll()
    {
      Packlist.Clear();
    }




  }

}