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
            StageNumber = 1;
            Console.WriteLine("What's your name?");
            player.Name = Console.ReadLine();
            Console.Clear();

            //Start Stages
            StageNumber = Start.StartStage1(player, StageNumber);
            Start.PrepareForNextStage(player, StageNumber);

            StageNumber = Start.StartStage2(player, StageNumber);
            Start.PrepareForNextStage(player, StageNumber);

            StageNumber = Start.StartStage3(player, StageNumber);

            //If compiler come this far means the player wins
            PlayerWonGame();
        }
        public static void PlayerWonGame()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("You Win!");
            Console.ResetColor();
        }
    }
}
// Fin justeringar (t.ex färg) + buggar
