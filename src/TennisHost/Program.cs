using System;
using Tennis;

namespace TennisHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Belgian Open");
            string player1 = "Rafael Nadal";
            string player2 = "Roger Federer";
            Game game = new Game(player1, player2);
            Random r = new Random();
            string score;
            while (!(score = game.GetScore()).Contains("Win"))
            {
                int v = r.Next(0, 101);
                if (v % 2 == 0)
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
