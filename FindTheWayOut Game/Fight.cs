using System;
using System.Collections.Generic;
using System.Text;

namespace FindTheWayOut_Game
{
    class Fight
    {
        Monsters _monsters = new Monsters();
        Random rnd = new Random();
        public void Stage1FightEvent(Player player)
        {
            int MonsterCount = _monsters.Tier1Monsters().Count;
            int MonsterIndex = rnd.Next(0, MonsterCount);
            var Monster = _monsters.Tier1Monsters()[MonsterIndex];

            player.Health -= Monster.Attack;
            if (player.Health <= 0)
            {
                GameOver();
            }

            Start.DisplayPlayerStats(player);
        }
        public void Stage2FightEvent(Player player)
        {
            int MonsterCount = _monsters.Tier2Monsters().Count;
            int MonsterIndex = rnd.Next(0, MonsterCount);
            var Monster = _monsters.Tier2Monsters()[MonsterIndex];

            player.Health -= Monster.Attack;
            if (player.Health <= 0)
            {
                GameOver();
            }

            Start.DisplayPlayerStats(player);
        }
        public void Stage3FightEvent(Player player)
        {
            int MonsterCount = _monsters.Tier3Monsters().Count;
            int MonsterIndex = rnd.Next(0, MonsterCount);
            var Monster = _monsters.Tier3Monsters()[MonsterIndex];

            player.Health -= Monster.Attack;
            if (player.Health <= 0)
            {
                GameOver();
            }

            Start.DisplayPlayerStats(player);
        }
        public void GameOver()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(52, 10);
            Console.WriteLine("Game Over");
            Console.SetCursorPosition(39, 11);
            Console.WriteLine("Do you want to restart and try again? Yes/No");
            Console.ResetColor();
            string UserInput = Console.ReadLine().ToUpper();

            while (UserInput != "YES" && UserInput != "NO")
            {
                Console.Clear();
                Console.WriteLine("You must enter an answer (Yes or No)");
                UserInput = Console.ReadLine().ToUpper();
            }

            if (UserInput == "YES")
            {
                Console.Clear();
                Program.StartGame();
            }
            else
            {
                Console.WriteLine("Exiting Game...");
                Environment.Exit(0);
            }
        }
    }
}
