using System;

namespace NullsInCSharp.Fundamentals
{
  public static class PlayerDisplayer
  {
    public static void ShowPlayerDetails(Player player)
    {
      Console.WriteLine($"Player Name: {player.Name}");

      // Bad Code
      // if (player.DaysSinceLastLogin == -1)
      // Good Code 
      if (player.DaysSinceLastLogin == null)
      {
        Console.WriteLine("No entry for last logged in");
      }
      else
      {
        Console.WriteLine($"Days Since Last Login is: {player.DaysSinceLastLogin}");
      }

      // Bad Code 
      // if (player.DateOfBirth == DateTime.MinValue)
      // Good Code 
      if (player.DateOfBirth == null)
      {
        Console.WriteLine("No entry for date of birth");
      }
      else
      {
        Console.WriteLine($"Date of birth is: {player.DateOfBirth}");
      }
    }
  }
}