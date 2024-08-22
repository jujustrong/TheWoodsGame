using System;
using System.Collections.Generic;
using System.Linq;

namespace TheWoodsGame;

public class Hiker
{
    public string Name { get; set; }
    public int FoodSlots { get; set; }
    public int HealthPoints { get; set; }
    public int DailyMileage { get; set; }
    public int TotalMileage { get; set; }
    public List<string> Bag { get; set; } = new List<string>();

    public Hiker(string name)
    {
        Name = name;
        FoodSlots = 3;
        HealthPoints = 10;
        Bag = [];
        DailyMileage = 0;
        TotalMileage = 0;
    }

    public void HikeDownPath(string direction)
    {
        Console.WriteLine($"{Name} continues down the {direction}");
        DailyMileage += 10;
    }

    public void AddToBag(string item)
    {
        Bag.Add(item);
        Console.WriteLine($"{item} added to bag.");
    }
    
    public void ShowContents()
    {
        if (Bag.Count > 0)
        {
            Console.WriteLine($"Your bag contains: ");
            foreach (var item in Bag)
            {
                Console.WriteLine($"{item}");
            }
        }
        else {Console.WriteLine($"{Name}'s bag is empty");}
    }

    public void CheckCurrentStats()
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("Current Stats:");
        Console.WriteLine(
            $"Name: {Name}\nFood Slots: {FoodSlots}\n" +
            $"Health Points: {HealthPoints}\nTotal Mileage: {TotalMileage}\n" +
            $"Daily Mileage: {DailyMileage}"
        ); ShowContents();
        Console.ForegroundColor = ConsoleColor.Yellow;
    }
    
    public void SetUpCamp()
    {
        if (DailyMileage >= 20)
        {
            Console.WriteLine($"{Name} sets up camp");
            FoodSlots--;
            Console.WriteLine($"Food slots remaining: {FoodSlots}");
            HealthPoints++;
            Console.WriteLine($"Health Point gained! Health Points remaining: {HealthPoints}");
            DailyMileage = 0;
        }
        else
        {
            Console.WriteLine("You have not hiked far enough to set up camp.");
        }
    }
}