using System;

namespace Fundamentals
{
  public static class PlayerDisplayer
  {
    public static void ShowPlayerDetails(Player player)
    {
      Console.WriteLine($"Player Name: {player.Name}");

      if (player.DaysSinceLastLogin == -1)
      {
        Console.WriteLine("No entry for last logged in");
      }
      else
      {
        Console.WriteLine($"Days Since Last Login is: {player.DaysSinceLastLogin}");
      }

      if (player.DateOfBirth == DateTime.MinValue)
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