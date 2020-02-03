using System.Collections.Generic;
using System.Collections;
using ConsoleAdventure.Project.Interfaces;

namespace ConsoleAdventure.Project.Models
{
  public class Room : IRoom
  {
    public string Name { get; set; }
    public string Description { get; set; }
    public List<Item> Items { get; set; }
    public Dictionary<string, IRoom> Exits { get; set; }

    public void AddExit(string direction, Room exit)
    {
      Exits.Add(direction, exit);
      // //Add this room as exit to other 
      // des.Exits.Add(Code, this);
    }
    public Room(string name, string description, IEnumerable<Item> items, Dictionary<string, IRoom> exits)
    {
      Name = name;
      Description = description;
      Items = new List<Item>();
      Items.AddRange(items);
      Exits = exits;
    }
    public Room(string name, string description, IEnumerable<Item> items)
    {
      Name = name;
      Description = description;
      Items = new List<Item>();
      Items.AddRange(items);
    }
    public Room(string name, string description)
    {
      Name = name;
      Description = description;
    }
  }
}