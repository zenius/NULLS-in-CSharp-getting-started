using System;

namespace Fundamentals
{
  class Program
  {
    static void Main(string[] args)
    {
      //   FirstExample();
      //   SecondExample();
      ThirdExample();

    }

    private static void ThirdExample()
    {
      Player player = new Player(3)
      {
        Name = "Zen"
      };

      PlayerDisplayer.ShowPlayerDetails(player);
    }

    private static void SecondExample()
    {
      Player player = new Player(2)
      {
        Name = "Bharat",
        DateOfBirth = new DateTime(1993, 3, 24),
        DaysSinceLastLogin = 3
      };

      PlayerDisplayer.ShowPlayerDetails(player);
    }

    private static void FirstExample()
    {
      Player player = new Player(1) { Name = "Zenius" };

      PlayerDisplayer.ShowPlayerDetails(player);
    }
  }
}
