﻿using System;

namespace FindTheWayOut_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            Console.WriteLine("What's your name?");
            player.Name = Console.ReadLine();

            Start.StartStage1(player);
        }
    }
}
// Skriv ut information om vilka monster för just den mappen det som finns (loopa igenom respektive monsterlista)