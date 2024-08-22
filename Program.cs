using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Linq;
using System.Threading;
using System.Threading.Channels;

namespace TheWoodsGame;

class Program
{
    
    static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("'Where am I? How did I get so lost?'");
        Thread.Sleep(2000);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("You must find your way through to survive.");
        Thread.Sleep(2000);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Welcome to The Woods");
        Thread.Sleep(2000);
        Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine();

        Console.Write("Play Game? (Y/N) ");
        var play = Console.ReadLine().ToLower();

        while (play == "y")
        {
            Console.Write("What is your hikers name? ");
            var hiker = new Hiker(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("RULES and KEYS:");
            Console.WriteLine("To check current stats Enter: STATS");
            Console.WriteLine("To check bag contents Enter: BAG");
            Console.WriteLine("To camp (only after 20miles) Enter: CAMP");
            Console.WriteLine("Every trail = 10 miles");
            Console.WriteLine("-1 HP every 10 miles");
            Console.WriteLine("-1 Food Slot every Camp");
            Thread.Sleep(2000);
            Console.WriteLine();
            hiker.CheckCurrentStats();
            Thread.Sleep(5000);
            Console.WriteLine("Which trail will you go down? left/middle/right");
            var trailOne = Console.ReadLine().ToLower();
            
            if (trailOne == "left")
            {
                hiker.HikeDownPath(trailOne);
                Thread.Sleep(2000);
                Console.WriteLine("You found a flashlight!");
                var flashlight = "Flashlight";
                Console.Write("Add to bag? (Y/N) ");
                if (Console.ReadLine().ToLower() ==  "y") {hiker.AddToBag(flashlight);}
                else { Console.WriteLine($"{flashlight} was not added to bag."); }
            }
            else if (trailOne == "middle")
            {
                Console.WriteLine("you chose middle");
            }
            else if (trailOne == "right")
            {
                Console.WriteLine("you chose right");
            }
            else if (trailOne == "stats")
            {
                hiker.CheckCurrentStats();
            }
            else if (trailOne == "bag")
            {
                hiker.ShowContents();
            }
            else if (trailOne == "camp")
            {
                hiker.SetUpCamp();
            }
            else
            {
                Console.WriteLine("Error");
            }
            
            break;
        }
        
    }
    
    
    
}