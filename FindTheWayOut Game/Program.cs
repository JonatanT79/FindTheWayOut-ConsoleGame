using System;

namespace FindTheWayOut_Game
{
    class Program
    {
        public static int StageNumber { get; set; } = 1;
        static void Main(string[] args)
        {
            StartGame();
        }
        public static void StartGame()
        {
            Player player = new Player();
            Console.WriteLine("What's your name?");
            player.Name = Console.ReadLine();
            Console.Clear();

            //Start Stages
            StageNumber = Start.StartStage1(player, StageNumber);
            Start.PrepareForNextStage(player, StageNumber);

            StageNumber = Start.StartStage2(player, StageNumber);
        }
    }
}

// Fixa att mapparna resetas när man startar om spelet
// Fixa Stage3
// Fin justeringar + buggar
