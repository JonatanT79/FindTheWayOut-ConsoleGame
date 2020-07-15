using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindTheWayOut_Game
{
    static class Start
    {
        public static void StartStage1(Player player)
        {
            Map _map = new Map();
            Movement _movement = new Movement();
            _map.Stage1();
            DisplayPlayerStats(player);
            SymbolInfo();
            DisplayPlayerInventory(player.Inventory);
            _movement.SetPlayerStartPosition(player);
            _movement.MoveCharacter(player);
        }

        public static void DisplayPlayerStats(Player player)
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Name: " + player.Name);
            Console.WriteLine("Health: " + player.Health);
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

            //Activity Log
            Console.SetCursorPosition(54, 15);
            Console.WriteLine("Activity Log");
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
        public static void LineDivide()
        {
            Console.WriteLine("-----------------------------------");
        }
    }
}
