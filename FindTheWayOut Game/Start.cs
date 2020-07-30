﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindTheWayOut_Game
{
    static class Start
    {
        public static int StartStage1(Player player, int StageNumber)
        {
            Map _map = new Map();
            Movement _movement = new Movement();

            _map.Stage1();
            DisplayCurrentStage(StageNumber);
            DisplayCurruntStageMonsters(StageNumber);
            DisplayPlayerStats(player);
            DisplayPlayerInventory(player.Inventory);
            SymbolInfo();
            _movement.SetPlayerStartPosition(player, StageNumber);
            _movement.MoveCharacter(player, StageNumber);
            StageNumber++;

            return StageNumber;
        }
        public static int StartStage2(Player player, int StageNumber)
        {
            Map _map = new Map();
            Movement _movement = new Movement();

            Console.Clear();
            _map.Stage2();
            DisplayCurrentStage(StageNumber);
            DisplayCurruntStageMonsters(StageNumber);
            DisplayPlayerStats(player);
            DisplayPlayerInventory(player.Inventory);
            SymbolInfo();
            _movement.SetPlayerStartPosition(player, StageNumber);
            _movement.MoveCharacter(player, StageNumber);
            StageNumber++;

            return StageNumber;
        }
        public static void DisplayCurrentStage(int StageNumber)
        {
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Current stage: " + StageNumber);
        }
        public static void DisplayCurruntStageMonsters(int StageNumber)
        {
            Monsters _monsters = new Monsters();
            Console.SetCursorPosition(0, 15);
            Console.WriteLine("Available monsters in this Stage/Map");

            if(StageNumber == 1)
            {
                foreach (var item in _monsters.Tier1Monsters())
                {
                    Console.WriteLine(item.Name + " - " + item.Attack + " Attack");
                }
            }
            else if (StageNumber == 2)
            {
                foreach (var item in _monsters.Tier2Monsters())
                {
                    Console.WriteLine(item.Name + " - " + item.Attack + " Attack");
                }
            }
            else if (StageNumber == 3)
            {
                foreach (var item in _monsters.Tier3Monsters())
                {
                    Console.WriteLine(item.Name + " - " + item.Attack + " Attack");
                }
            }
        }
        public static void DisplayPlayerStats(Player player)
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Name: " + player.Name);
            Console.WriteLine("Health: " + player.Health);
            LineDivide();
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
        public static void LineDivide()
        {
            Console.WriteLine("-----------------------------------");
        }
    }
}
