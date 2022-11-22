// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChooseYourOwnAdventure
{
  class Program
  {
    static void Main(string[] args)
    {
    gameTitle();
    first();
    second();
    third();
    fourth();
    }

    public static void gameTitle()
    {
    /* HOTEL NOIRE */

    // Start by asking for the user's name:
    Console.Clear();
    Console.Write("HOTEL NOIRE: A Murder/Mystery Text Game \n");
    Console.Write("By: Christopher Fergo Jr. \n");
    Console.Write("(c) 2022 \n \n");
    Console.Write("Enter your name?: ");
    string? name = Console.ReadLine();
    Console.Clear();
    Console.WriteLine($"Hello, {name}! Welcome to HOTEL NOIRE.");
    Console.WriteLine("Press 'ENTER' to begin adventure.");
    Console.ReadLine();
    Console.Clear();
    first();
    }

    public static void first()
    {
    Console.Clear();
    Console.Write("Our story begins on a cold and wet December night. You've been driving for hours when finally you arrive at your destination THE HOLLOWS INN. \n");
    Console.Write("You grab your luggage from the trunk and enter the lobby. \n");
    Console.Write("You look around. No one is there to greet you. \n");
    Console.Write("You notice a BELL on the counter.\n");
    Console.Write("What do you do?: ");
    string? ringChoice = Console.ReadLine()!.ToUpper();

      if (ringChoice == "RING" || ringChoice == "RING BELL")
      {
        Console.Write("An overweight, greasy looking man approaches you from behind the desk.\n\"My name is Mr. Dunning. Welcome to the Hollows Inn. Will you be STAYING with us tonight?\" \n");
        second();
      }
      else if (ringChoice == "EXIT" || ringChoice == "LEAVE") 
      {
          Console.Write("You decide this hotel looks like a dump and leave. \n Pretty anti-climatic. \n THE END! \n");
          Console.Write("Press 'ENTER' to restart game.");
          Console.ReadLine();
          Console.Clear();
          gameTitle();
      }
      else 
      {
          Console.WriteLine("You must reply RING or LEAVE.");
          Console.WriteLine("Press 'Enter' to continue.");
          Console.ReadLine();
          first();
      }
    }
  
    public static void second()
    {
    Console.Write("STAY at Hollows Inn?: ");
    string? stayChoice = Console.ReadLine()!.ToUpper();
        
      if (stayChoice == "YES" || stayChoice == "STAY")
      {
        Console.Write($"Mr. Dunning answers excitedly \"Excellent! It will be $100 a night. You'll be staying in ROOM 6. Let me get your KEY.\" \n");
        Console.Write("Mr Dunning hands you the KEY. \n");
        third();
      }
      else if (stayChoice == "NO" || stayChoice == "LEAVE")
      {
          Console.Clear();
          Console.Write("Mr. Dunning frowns.\n \"Well then don't waste my time!\" \n ");
          Console.Write("You leave the hotel. Pretty anti-climatic. \n ");
          Console.Write("THE END! \n");
          Console.Write("Press 'ENTER' to restart game.");
          Console.ReadLine();
          Console.Clear();
          gameTitle();
      }
      else
      {
          Console.Clear();
          Console.WriteLine("You must reply Yes or no. \n");
          Console.WriteLine("Press 'Enter' to continue.");
          Console.ReadLine();
          second();
      }
    }
    public static void third()
    {
      Console.Write("You proceed around the lobby. \n");
      Console.Write("In front of you is the STAIRS. To your left is an old ELEVATOR. \n");
      Console.Write("Which do you take?: ");
      string? elevationChoice = Console.ReadLine()!.ToUpper();

      if (elevationChoice == "STAIRS")
      {
        Console.Write("You proceed up the stairs to your room. \n");
        fourth();
      }
      else if (elevationChoice == "ELEVATOR")
      {
        Console.Write("The ELEVATOR reads \"Out of Order\" \n");
        Console.Write("Maybe you should try the STAIRS. \n");
        Console.WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        third();
      }
      else 
      {
        Console.Write("You must choose between ELEVATOR or STAIRS \n");
        Console.WriteLine("Press 'Enter' to continue.");
        Console.ReadLine();
        third();
      }
    }

    public static void fourth()
    {
      Console.Write("At the top of the stairs is a sign \n");
      Console.Write("<-- ROOMS 1-5 | ROOMS 6-10 --> \n");
      Console.Write("Which way do you go?: ");
      string? hallwayChoice = Console.ReadLine()!.ToUpper();

      if (hallwayChoice == "LEFT")
      {
        Console.Write("You decide to go left. \n");
        Console.Write("Rooms 1-5 are down this hallway. \n");
        Console.Write("Which room will you choose?: ");
        //switch statement here

      }
      else if (hallwayChoice == "RIGHT")
      {
        Console.Write("You decide to go right. \n");
        Console.Write("Rooms 6-10 are down this hallway. \n");
        Console.Write("Which room will you choose?: ");
        //switch statement here
      }
      else
      {
        Console.Write("You must choose a direction. \n");
        Console.Write("LEFT or RIGHT. \n");
        Console.ReadLine();
        fourth();
      }
    }
  }
}
