using System;
using System.Collections.Generic;
using System.Text;

namespace FindTheWayOut_Game
{
    static class Start
    {
        public static void StartStage1()
        {
            Map _map = new Map();
            Movement _movement = new Movement();
            _map.Stage1();
            DisplayPlayerStats();
            SymbolInfo();
            _movement.SetPlayerStartPosition();
            _movement.MoveCharacter();
        }

        public static void DisplayPlayerStats()
        {
            Player _player = new Player();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Name:" + _player.Name);
            Console.WriteLine("Health:" + _player.Health);
            LineDivide();
        }
        public static void SymbolInfo()
        {
            Console.SetCursorPosition(0, 5);
            Console.WriteLine("@ = You");
            Console.WriteLine("M = Monster");
            Console.WriteLine("# = Wall");
            Console.WriteLine(". = Floor");
            Console.WriteLine("K = Key");
            Console.WriteLine("A = Axe");
            Console.WriteLine("S = Sword");
            Console.WriteLine("D = Door");
            Console.WriteLine("E = Exit");
        }
        public static void LineDivide()
        {
            Console.WriteLine("-----------------------------------");
        }
    }
}
