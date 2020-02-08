using System;


namespace Fundamentals
{
  public class Player
  {
    public int Id { get; set; }
    public string Name { get; set; }

    // public int DaysSinceLastLogin { get; set; }
    public Nullable<int> DaysSinceLastLogin { get; set; }

    // public DateTime DateOfBirth { get; set; }
    // ShortHand Notation for Nullable types
    public DateTime? DateOfBirth { get; set; }

    public Player(int Id)
    {
      this.Id = Id;

      // Bad Code
      // this.DaysSinceLastLogin = -1; // magic number
      // this.DateOfBirth = DateTime.MinValue; // magic number 

      // Good Code 
      this.DaysSinceLastLogin = null;
      this.DateOfBirth = null;
    }

  }
}