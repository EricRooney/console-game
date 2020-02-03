using System;
using System.Collections.Generic;
using ConsoleAdventure.Project.Interfaces;
using ConsoleAdventure.Project.Models;
using System.Threading;

namespace ConsoleAdventure.Project.Controllers
{

  public class GameController : IGameController
  {
    private GameService _gameService = new GameService();

    //NOTE Makes sure everything is called to finish Setup and Starts the Game loop
    private bool _playing = true;
    public void Run()
    {
      MainTitle.PrintMainTitle();
      Console.WriteLine("Hello, Please enter your name");
      string UserName = Console.ReadLine();
      _gameService.Setup(UserName);
      while (_playing)
      {
        Console.Clear();
        MainTitle.PrintMainTitle();
        Print();
        GetUserInput();

      }
      Console.Clear();
      MainTitle.PrintMainTitle();
      Console.Write("Thanks for playing Volitile the game!");
      Thread.Sleep(2000);
      Console.Clear();


    }

    //NOTE Gets the user input, calls the appropriate command, and passes on the option if needed.
    public void GetUserInput()
    {
      Console.WriteLine("What would you like to do?");
      string input = Console.ReadLine().ToLower() + " ";
      string command = input.Substring(0, input.IndexOf(" "));
      string option = input.Substring(input.IndexOf(" ") + 1).Trim();
      //NOTE this will take the user input and parse it into a command and option.
      //IE: take silver key => command = "take" option = "silver key"

    }

    //NOTE this should print your messages for the game.
    private void Print()
    {
      foreach (Message message in _gameService.Messages)
      {
        message.Print();
      }
      _gameService.Messages.Clear();
    }

  }
}