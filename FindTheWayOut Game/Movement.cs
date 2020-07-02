using System;
using System.Collections.Generic;
using System.Linq;

namespace FindTheWayOut_Game
{
    class Movement
    {
        public Coordinate PlayerChar { get; set; }
        Player _player = new Player();
        public void MoveCharacter()
        {
            ConsoleKeyInfo keyInfo;

            //loopa igenom gå-kommandot så länge villkoret är true
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
            {
                if (keyInfo.Key == ConsoleKey.UpArrow || keyInfo.Key == ConsoleKey.W)
                {
                    // anropar metoden och minskar y koordinaten med 1
                    ModifyPosition(0, -1);
                }
                else if (keyInfo.Key == ConsoleKey.RightArrow || keyInfo.Key == ConsoleKey.D)
                {
                    // anropar metoden och ökar x koordinaten med 1
                    ModifyPosition(1, 0);
                }
                else if (keyInfo.Key == ConsoleKey.DownArrow || keyInfo.Key == ConsoleKey.S)
                {
                    ModifyPosition(0, 1);
                }
                else if (keyInfo.Key == ConsoleKey.LeftArrow || keyInfo.Key == ConsoleKey.A)
                {
                    ModifyPosition(-1, 0);
                }
            }
        }

        public void ModifyPosition(int x, int y)
        {
            Coordinate NewHeroPosition = new Coordinate()
            {
                // om x är 1 och y är 0 --> x = Hero.x(Gubbens startposition x) + 1, gubben gick höger
                x = PlayerChar.x + x,
                y = PlayerChar.y + y
            };
            string GetMapSymbol = Map.Stage1Map[NewHeroPosition.y, NewHeroPosition.x - 44];

            if (CanMove(GetMapSymbol))
            {
                // anropar metoden som tar bort det föregående tecknet efter förflyttning
                RemoveHero();

                Console.SetCursorPosition(NewHeroPosition.x, NewHeroPosition.y);
                Console.ForegroundColor = ConsoleColor.Green;

                // skriv ut tecknet på gubbens nya position
                Console.Write("@");
                Console.ResetColor();
                // Ge den gamla "Hero" den nya positionen
                PlayerChar = NewHeroPosition;
            }
        }
        public void RemoveHero()
        {
            // skriver ut en punkt på gubbens gamla position i kartan
            Console.SetCursorPosition(PlayerChar.x, PlayerChar.y);
            Console.Write(".");
        }

        public bool CanMove(string MapSymbol)
        {
            if (MapSymbol == "#")
            {
                return false;
            }
            else if (MapSymbol == "A")
            {
                Items _items = new Items() { Name = "Axe" };
                _player.Inventory.Add(_items);

                Console.SetCursorPosition(53, 15);
                Console.WriteLine("Collected 1 Axe");
                Start.DisplayPlayerInventory(_player.Inventory);
            }
            else if (MapSymbol == "S")
            {
                Items _items = new Items() { Name = "Sword" };
                _player.Inventory.Add(_items);

                Console.SetCursorPosition(53, 15);
                Console.WriteLine("Collected 1 Sword");
                Start.DisplayPlayerInventory(_player.Inventory);
            }
            else if (MapSymbol == "K")
            {
                Items _items = new Items() { Name = "Key" };
                _player.Inventory.Add(_items);

                Console.SetCursorPosition(53, 15);
                Console.WriteLine("Collected 1 Key");
                Start.DisplayPlayerInventory(_player.Inventory);
            }
            else if (MapSymbol == "D")
            {
                var PlayerInventory = _player.Inventory;

                var AxeSearch = from e in PlayerInventory
                                where e.Name == "Axe"
                                group e by e.Name into Item
                                select new
                                {
                                    Count = Item.Count()
                                };

                var AxeCount = 0;
                if (AxeSearch.Count() != 0)
                {
                    AxeCount = AxeSearch.ToList()[0].Count;
                }

                if (AxeCount > 0)
                {
                    var Axe = PlayerInventory.Where(d => d.Name == "Axe").FirstOrDefault();
                    PlayerInventory.Remove(Axe);
                    Start.DisplayPlayerInventory(PlayerInventory);

                    return true;
                }

                return false;
            }
            else if (MapSymbol == "M")
            {
                var PlayerInventory = _player.Inventory;

                var SwordSearch = from e in PlayerInventory
                                  where e.Name == "Sword"
                                  group e by e.Name into Item
                                  select new
                                  {
                                      Count = Item.Count()
                                  };

                int SwordCount = 0;
                if (SwordSearch.Count() != 0)
                {
                    SwordCount = SwordSearch.ToList()[0].Count;
                }

                if (SwordCount > 0)
                {
                    //FightEvent

                    var Sword = PlayerInventory.Where(e => e.Name == "Sword").FirstOrDefault();
                    PlayerInventory.Remove(Sword);
                    Start.DisplayPlayerInventory(PlayerInventory);

                    return true;
                }

                return false;
            }
            else if (MapSymbol == "E")
            {
                var PlayerInventory = _player.Inventory;

                var KeySearch = from e in PlayerInventory
                                where e.Name == "Key"
                                group e by e.Name into Item
                                select new
                                {
                                    Count = Item.Count()
                                };

                int KeyCount = 0;
                if (KeySearch.Count() != 0)
                {
                    KeyCount = KeySearch.ToList()[0].Count;
                }

                if (KeyCount != 0)
                {
                    var Key = PlayerInventory.Where(e => e.Name == "Key").FirstOrDefault();
                    PlayerInventory.Remove(Key);
                    Start.DisplayPlayerInventory(PlayerInventory);

                    return true;
                }

                return false;
            }

            return true;
        }

        public void SetPlayerStartPosition()
        {
            // Tilldelar gubbens startposition + initierar PlayerChar
            PlayerChar = new Coordinate() { x = 46, y = 12 };

            // en del av startpositionen, sätt alltid 0,0 för att gubben ska utgå från startpositionen vid koordinaten ovanför ^^
            ModifyPosition(0, 0);
        }
    }
}
