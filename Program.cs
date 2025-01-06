using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPoints = 0;
            int rivalPoints = 0;

            Console.WriteLine("Dice Game\n");
            Console.WriteLine("In this game you and a computer Rival will play 10 rounds");
            Console.WriteLine("where you will each roll a 6-sided dice, and the player");
            Console.WriteLine("with the highest dice value will win the round. The player");
            Console.WriteLine("who wins the most rounds wins the game. Good luck!\n");
            Console.WriteLine("Press any key to start...");
            Console.ReadKey(true);
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Round {i + 1}");
                int rivalnum = Random.Shared.Next(1, 7);
                Console.WriteLine("Rival rolled a " + rivalnum);
                Console.Write("Press any key to roll the dice...");
                Console.ReadKey(true);
                Console.WriteLine();
                int playernum = Random.Shared.Next(1, 7);
                Console.WriteLine("You rolled a " + playernum);
                if (playernum > rivalnum)
                {
                    playerPoints++;
                    Console.WriteLine("You won this round.");
                }
                else if (playernum < rivalnum)
                {
                    rivalPoints++;
                    Console.WriteLine("The Rival won this round.");
                }
                else
                {
                    Console.WriteLine("This round is a draw!");
                }
                Console.WriteLine($"The score is now - You : {playerPoints}. Rival : {rivalPoints}.");
                Console.Write("Press any key to continue...");
                Console.ReadKey(true);
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("Game over.");
            Console.WriteLine($"The score is now - You : {playerPoints}. Rival : {rivalPoints}.");
            if (playerPoints > rivalPoints)
            {
                Console.WriteLine("You won!");
            }
            else if (playerPoints < rivalPoints)
            {
                Console.WriteLine("You Lost!");
            }
            else
            {
                Console.WriteLine("This game is a draw.");
            }
            Console.Write("Press any key to exit...");
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("Dice Game was closed.");
        }
    }
}
