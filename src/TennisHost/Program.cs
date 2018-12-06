using System;
using Tennis;

namespace TennisHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Belgian Open");
            string player1 = "player1";
            string player2 = "player2";
            Game game = new Game(player1, player2);
            Random r = new Random();
            string score;
            while (!(score = game.GetScore()).Contains("Win"))
            {
                if (r.Next(0, 2) == 1)
                {
                    Console.WriteLine("Point for player 1");
                    game.WonPoint(player1);
                }
                else
                {
                    Console.WriteLine("Point for player 2");
                    game.WonPoint(player2);
                }
                score = game.GetScore();
                Console.WriteLine(score);
            };
        }
    }
}
