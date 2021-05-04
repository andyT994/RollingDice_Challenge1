using System;
using System.Collections.Generic;
namespace Challenge_1
{
    class Program
    {
        static void Main(string[] args) 
        {
            int DiceRandomNumb;

            Random Dice = new Random();

            List<int> dices = new List<int>();

            int[] DiceNumb = new int[10];
            Console.WriteLine(Dice);
            for (int i = 0; i < 10; i++)
    
        {
            DiceNumb[i] = Dice.Next(1, 6);
        {
            Console.WriteLine("Please Roll The Dice");
            
            Console.ReadKey();
            DiceRandomNumb = Dice.Next(1, 6);
            Console.WriteLine("You Roll A " + DiceRandomNumb);
        }

         Console.ReadKey();
        }
    } 
 }
}
