using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindTheWayOut_Game
{
    static class Start
    {
        static Player _player = new Player();
        public static void StartStage1()
        {
            Map _map = new Map();
            Movement _movement = new Movement();
            _map.Stage1();
            DisplayPlayerStats();
            SymbolInfo();
            DisplayPlayerInventory(_player.Inventory);
            _movement.SetPlayerStartPosition();
            _movement.MoveCharacter();
        }

        public static void DisplayPlayerStats()
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Name: " + _player.Name);
            Console.WriteLine("Health: " + _player.Health);
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
        public static void DisplayPlayerInventory(List<Items> PlayerInventory)
        {
            Console.SetCursorPosition(90, 5);
            Console.WriteLine("Your inventory:");

            var GroupInventoryItems = from e in PlayerInventory
                                      group e by e.Name into Items
                                      select new
                                      {
                                          Name = Items.Key,
                                          Count = Items.Count()
                                      };

            int row = 1;
            foreach (var item in GroupInventoryItems)
            {
                Console.SetCursorPosition(90, 5 + row);
                Console.WriteLine(item.Name + ": " + item.Count + " piece/pieces");
                row++;
            }

            //This removes old text on the row under
            Console.SetCursorPosition(90, 5 + row);
            Console.Write("                              ");
        }
    }
}
