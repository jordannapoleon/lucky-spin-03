using System;
namespace LuckySpin.Models;

public class Spin
{
    public required int Luck { get; set; } = 7;
    public required string Name {get; set;} = "Anonymous";
    public required int[] Numbers { get; set; } 
    public string ImageDisplay { 
        get{
            //TODO: Add logic here to return either "block" or "none" based on whether the Numbers array contains the Luck value
            return Numbers.Contains(Luck) ? "block" : "none";
        }
    }
    Random random = new Random();
    //TODO: Adjust Constructor to generate random Numbers for the Spin
    public Spin()
    {
        Numbers = [random.Next(1,9), random.Next(1,9), random.Next(1,9)];
    }

}
