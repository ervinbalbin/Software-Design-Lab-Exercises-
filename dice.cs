using System;
using System.Threading;
 
namespace RandomNumGen
{
   class Program
   {
       static void Main(string[] args)
       {
           Console.WriteLine("MENU");
           Console.WriteLine("You have four options and simply type in the option that you would like to select.");
           Console.WriteLine("Your options are:");
           Console.WriteLine("Dice Game");
           Console.WriteLine("Guessing Game");
           Console.WriteLine("Math Game");
           Console.WriteLine("Exit");
           string menu = Console.ReadLine();
           switch (menu.ToLowerInvariant())
           {
               case "dice game":
                   DiceGame();
                   break;
               case "guessing game":
                   GuessingGame();
                   break;
               case "math game":
                   MathGame();
                   break;
               case "exit":
                   Exit();
                   break;
               default:
                   Default();
                   break;
           }
 
       }
       static void Exit()
       {
           Console.WriteLine("Game Over");
       }
       static void Default()
       {
           Console.WriteLine("This option is currently not supported. Relaunch the program and try another option.");
       }
 
       static void MathGame()
       {
           Console.WriteLine("This option is currently not supported. Relaunch the program and try another option.");
       }
       static void GuessingGame()
       {
           Console.WriteLine("This option is currently not supported. Relaunch the program and try another option.");
       }
       static void DiceGame()
       {
           Console.WriteLine("Would you like to try to roll for a specific score? Y/n");
           var rollForTargetResponse = Console.ReadKey();
           Console.WriteLine();
           int? targetNumber = null;
           switch (rollForTargetResponse.Key)
           {
               case ConsoleKey.Y:
               case ConsoleKey.Enter:
                   targetNumber = GetNumber("Please give us the score that you would like to get:");
                   break;
               case ConsoleKey.N:
                   break;
               default:
                   throw new Exception("Not an accepted response");
           };
 
           Console.WriteLine("Please give us the number of dice that you would like to receive, then give is the number of sides that those dice should have.");
 
           var numOfDice = GetNumber("Number of dice: ");
           var numOfSides = GetNumber("Number of sides: ");
 
           var random = new Random();
           var totalRollValue = 0;
           var numberOfRolls = 0;
 
 
           while (totalRollValue != targetNumber)
           {
               totalRollValue = 0;
               numberOfRolls++;
 
               Console.WriteLine($"Roll # {numberOfRolls}");
 
               for (var i = 0; i < numOfDice; i++)
               {
                   var rollValue = random.Next(1, numOfSides);
                   Console.WriteLine($"Dice #{i + 1} rolled a {rollValue}.");
                   totalRollValue += rollValue;
               }
 
 
               if (targetNumber == null)
                   targetNumber = totalRollValue;
           }
 
           Console.WriteLine($"You rolled {numberOfRolls} times to get {totalRollValue}.");
           Thread.Sleep(1250);
           Console.WriteLine("Thank you for playing the dice game.");
       }
       internal static int GetNumber(string message)
       {
           int num = -1;
           while (num < 0)
           {
               Console.WriteLine(message);
               var numStr = Console.ReadLine();
               int.TryParse(numStr, out num);
           }
           return num;
       }
   }
}
