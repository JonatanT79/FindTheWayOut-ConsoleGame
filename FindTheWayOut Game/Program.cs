﻿using System;

namespace FindTheWayOut_Game
{
    class Program
    {
        public static int StageNumber { get; set; } = 1;
        static void Main(string[] args)
        {
            Player player = new Player();

            Console.WriteLine("What's your name?");
            player.Name = Console.ReadLine();
            Console.Clear();

            //Start Stages
            StageNumber = Start.StartStage1(player, StageNumber);
            StageNumber = Start.StartStage2(player, StageNumber);
        }
    }
}
// Fin justeringar + buggar
// starting next stage... text - Reset player inventory
// gameover metod
// Fixa Stage3
