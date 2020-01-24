using System;
using System.Collections.Generic;

namespace testing
{
  class Program
  {
    static void Main(string[] args)
    {
      List<string> CpuChoices = new List<string>()
        {
            "rock",
            "paper",
            "scissors"
        };
      Random rnd = new Random();
      bool playing = true;
      Console.Clear();
      Console.WriteLine("Welcome, what is your name?");
      string name = Console.ReadLine();
      Console.WriteLine($"Hello {name}! My name is Mr. Roboto and I am your opponent today. Are you ready to play a game? What game you might ask, why only the bestest game in the whole world; Rock, Paper, Scissors! Once we start playing, type anything other than 'rock', 'paper', or 'scissors' and it will exit the game. Once you're ready, press the SpaceBar.");
      ConsoleKeyInfo SecondKey = Console.ReadKey();
      if (SecondKey.Key == ConsoleKey.Spacebar)
      {
        while (playing)
        {
          Console.WriteLine("What is your move?");
          string PlayerChoice = Console.ReadLine();
          int ComputerChoice = rnd.Next(CpuChoices.Count);
          if (PlayerChoice == CpuChoices[ComputerChoice])
          {
            Console.WriteLine("We tied!");
          }
          else if ((PlayerChoice == "rock" && CpuChoices[ComputerChoice] == "scissors") || (PlayerChoice == "paper" && CpuChoices[ComputerChoice] == "rock") || (PlayerChoice == "scissors" && CpuChoices[ComputerChoice] == "paper"))
          {
            Console.WriteLine("You must have cheated...");
          }
          else if ((PlayerChoice == "rock" && CpuChoices[ComputerChoice] == "paper") || (PlayerChoice == "paper" && CpuChoices[ComputerChoice] == "scissors") || (PlayerChoice == "scissors" && CpuChoices[ComputerChoice] == "rock"))
          {
            Console.WriteLine("You need to practice more.");
          }
          else
          {
            Console.Clear();
            playing = false;
          }
        }
      }
      else
      {
        Console.Clear();
        Console.WriteLine("You scared?");
      }



    }
  }
}
