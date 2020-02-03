using System;
using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;


namespace ConsoleAdventure.Project.Models
{
  public class Game : IGame
  {
    public IRoom CurrentRoom { get; set; }
    public IPlayer CurrentPlayer { get; set; }

    //NOTE Make yo rooms here...
    public void Setup()
    {
      Item match = new Item("Match", "One Single Lone Individual Match");
      Item candle = new Item("Candle", "Looks like it should last a while");
      Item ladder = new Item("Ladder", "Just high enough to reach the ceiling as long as OSHA isn't watching");
      Item lightSwitch = new Item("Light Switch", "Looks to be toggleable");
      Room rm1 = new Room("Room 1", "Looks like it's got most of 4 walls", new Item[] { match, candle });
      Room rm2 = new Room("Room 2", "Looks like it's also got most of 4 walls");
      Room rm3 = new Room("Room 3", "Looks like it's also got most of 4 walls");
      Room rm4 = new Room("Room 4", "Looks like it's also got most of 4 walls", new Item[] { ladder });

      rm1.AddExit("north", rm2);
      rm2.AddExit("south", rm1);
      rm2.AddExit("north", rm3);
      rm3.AddExit("south", rm2);
      rm3.AddExit("north", rm4);
      rm4.AddExit("south", rm3);

      CurrentRoom = rm1;
    }
  }
}