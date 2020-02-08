using System;


namespace Fundamentals
{
  public class Player
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public int DaysSinceLastLogin { get; set; }

    public DateTime DateOfBirth { get; set; }

    public Player(int Id)
    {
      this.Id = Id;
      this.DaysSinceLastLogin = -1; // magic number
      this.DateOfBirth = DateTime.MinValue; // magic number 
    }

  }
}