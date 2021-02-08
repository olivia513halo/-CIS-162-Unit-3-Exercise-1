using System;

class MainClass {
  public static void Main (string[] args) {
    Pirate pirateOne = new Pirate();
    Job pirateJob = new Job();
    Ship theShip = new Ship();
    pirateOne.BeardVolume = 5;
    pirateOne.MissingLimbs = 12;
    pirateJob.CrewRole = "Captain";
    pirateJob.SkilledIn = "Sword";
    theShip.NumOfCannons = 5;
    theShip.SpeedOfShip = 40;
    Console.WriteLine($"\nHello I am a pirate.\nI have a voluminous beard that measures {pirateOne.BeardVolume} cubic feet.\nI have fought in many battles and succumbed to scurvy numerous times.\nThis has led to my {pirateOne.MissingLimbs} missing limbs.");
  }
}
class Pirate
{
  public int BeardVolume {get;set;}
  public int MissingLimbs {get;set;}
}
class Job
{
  public string CrewRole {get;set;}
  public string SkilledIn {get;set;} 
}
class Ship
{
  public int NumOfCannons {get;set;}
  public int SpeedOfShip {get;set;}
}